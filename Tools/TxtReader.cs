using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace TestCreatorAndSolver
{
    internal class TxtReader
    {
        public static void CopyFile(string oldPath, string newPath)
        {
            try
            {
                File.Copy(oldPath, newPath);
                File.SetAttributes(newPath, File.GetAttributes(newPath) | FileAttributes.ReadOnly);
            }
            catch
            {
                MessageBox.Show("Fayl topilmadi", "Xato!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static Dictionary<string, (int correctIndex, List<string> answers)> ReadQuestions(string filePath, Guna2HtmlLabel infoLabel)
        {

            Dictionary<string, (int correctIndex, List<string> answers)> questionsDict = new Dictionary<string, (int correctIndex, List<string> answers)>();
            string currentQuestion = "";
            List<string> currentAnswers = new List<string>();
            int correctIndex = -1;

            if (!File.Exists(filePath))
            {
                infoLabel.Text = "Fayl mavjud emas";
                infoLabel.ForeColor = Color.Red;
                return null;
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (line.StartsWith("#"))
                {
                    if (!string.IsNullOrEmpty(currentQuestion) && currentAnswers.Count > 0)
                    {
                        if (!questionsDict.ContainsKey(currentQuestion))
                        {
                            questionsDict.Add(currentQuestion, (correctIndex, currentAnswers));
                            currentAnswers = new List<string>();
                            correctIndex = -1;
                        }
                    }

                    // Устанавливаем новый текущий вопрос
                    currentQuestion = line.TrimStart('#');
                }
                else if (line.StartsWith("+")) // Если строка начинается с "+", это правильный ответ
                {
                    currentAnswers.Add(line.TrimStart('+'));
                    correctIndex = currentAnswers.Count - 1;
                }
                else if (line.StartsWith("-")) // Если строка начинается с "-", это неправильный ответ
                {
                    currentAnswers.Add(line.TrimStart('-'));
                }
                else if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                else
                {
                    infoLabel.Text = "Savollar notog'ri tuzilgan";
                    infoLabel.ForeColor = Color.Red;
                    return null;
                }

            }
            if (correctIndex == -1)
            {
                infoLabel.Text = "Savollar orasida tog'ri javob boshida '+' belgisi bo'lsin";
                infoLabel.ForeColor = Color.Red;
                return null;
            }
            if (!string.IsNullOrEmpty(currentQuestion) && currentAnswers.Count > 0)
            {
                questionsDict.Add(currentQuestion, (correctIndex, currentAnswers));
            }
            return questionsDict;
        }
        public static void WriteToJSONSubjectAndNewPath(string subjectName, string newfilePath)
        {
            string JSONPath = $"{Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 10, 10)}/data.json";
            string jsonFromFile = File.ReadAllText(JSONPath);
            var existingData = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonFromFile);

            existingData.Add(subjectName, newfilePath);

            var options = new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(existingData, options);
            File.WriteAllText(JSONPath, jsonString);

            MessageBox.Show("Saqlandi", "Muvaffaqiyatli", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void RemoveSubjectFromJSON(string subjectName)
        {
            string JSONPath = $"{Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 10, 10)}/data.json";

            if (!File.Exists(JSONPath))
            {
                MessageBox.Show("JSON fayli topilmadi!", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string jsonFromFile = File.ReadAllText(JSONPath);
            var existingData = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonFromFile);

            if (existingData.ContainsKey(subjectName))
            {
                existingData.Remove(subjectName);

                var options = new JsonSerializerOptions
                {
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    WriteIndented = true
                };
                string jsonString = JsonSerializer.Serialize(existingData, options);
                File.WriteAllText(JSONPath, jsonString);

            }

        }

        public static void FillSubjectsCombobox(Guna2ComboBox comboBox)
        {
            comboBox.Items.Clear();
            string JSONPath = $"{Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 10, 10)}/data.json";
            if (File.Exists(JSONPath))
            {
                string jsonFromFile = File.ReadAllText(JSONPath);

                var dictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonFromFile);

                foreach (var key in dictionary.Keys)
                {
                    comboBox.Items.Add(key);
                }
            }
            else
            {
                MessageBox.Show("data.json fayli topilmadi", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void FillRichTextBox(RichTextBox richTextBox, string key)
        {
            string JSONPath = $"{Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 10, 10)}/data.json";
            if (File.Exists(JSONPath))
            {
                string jsonFromFile = File.ReadAllText(JSONPath);
                var dictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonFromFile);
                string allText = File.ReadAllText(dictionary[key]);
                richTextBox.Text = allText;
            }
            else
            {
                MessageBox.Show("data.json fayli topilmadi", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void RemoveJSONElementWithKey(string key)
        {
            string filePath = $"{Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 10, 10)}/data.json";
            if (File.Exists(filePath))
            {
                string jsonFromFile = File.ReadAllText(filePath);

                var dictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonFromFile);
                dictionary.Remove(key);

                var options = new JsonSerializerOptions
                {
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                    WriteIndented = true
                };

                string jsonString = JsonSerializer.Serialize(dictionary, options);

                File.WriteAllText(filePath, jsonString);

            }
            else
            {
                MessageBox.Show("data.json fayli topilmadi", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static Dictionary<string, (string TrueAnswer, List<string> answers)> GetQuestionsDic(string filePath)
        {
            Dictionary<string, (string TrueAnswer, List<string> answers)> questionsDict = new Dictionary<string, (string TrueAnswer, List<string> answers)>();
            string currentQuestion = "";
            List<string> currentAnswers = new List<string>();
            string TrueAnswer = "";

            if (!File.Exists(filePath))
            {
                return null;
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (line.StartsWith("#"))
                {
                    if (!string.IsNullOrEmpty(currentQuestion) && currentAnswers.Count > 0)
                    {
                        if (!questionsDict.ContainsKey(currentQuestion))
                        {
                            questionsDict.Add(currentQuestion, (TrueAnswer, currentAnswers));
                            currentAnswers = new List<string>();
                            TrueAnswer = "";
                        }
                        
                    }
                    // Устанавливаем новый текущий вопрос
                    currentQuestion = line.TrimStart('#');
                }
                else if (line.StartsWith("+")) // Если строка начинается с "+", это правильный ответ
                {
                    currentAnswers.Add(line.TrimStart('+'));
                    TrueAnswer = line.TrimStart('+');
                }
                else if (line.StartsWith("-")) // Если строка начинается с "-", это неправильный ответ
                {
                    currentAnswers.Add(line.TrimStart('-'));
                }
                else if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                else
                {
                    return null;
                }

            }
            if (TrueAnswer == "")
            {
                return null;
            }
            if (!string.IsNullOrEmpty(currentQuestion) && currentAnswers.Count > 0)
            {
                questionsDict.Add(currentQuestion, (TrueAnswer, currentAnswers));
            }
            return questionsDict;
        }

        public static string GetPathOfTest(string key)
        {
            string JSONPath = $"{Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 10, 10)}/data.json";
            if (File.Exists(JSONPath))
            {
                string jsonFromFile = File.ReadAllText(JSONPath);
                var dictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonFromFile);
                return dictionary[key];
            }
            else
            {
                MessageBox.Show("data.json fayli topilmadi", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static void DeleteTxtFile(string filePath)
        {
            try
            {
                FileAttributes attributes = File.GetAttributes(filePath);
                if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    attributes &= ~FileAttributes.ReadOnly;
                    File.SetAttributes(filePath, attributes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при снятии атрибута 'только для чтения': " + ex.Message, "Ошибка");
                return;
            }
            try
            {
                File.Delete(filePath);
                MessageBox.Show("O'chirildi.", "Muvaffaqiyat");
            }
            catch {}
        }
    }
}
