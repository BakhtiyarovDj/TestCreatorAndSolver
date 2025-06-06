CREATE TABLE [dbo].[Admins] (
    [id]    INT           IDENTITY (1, 1) NOT NULL,
    [login] NVARCHAR (30) NOT NULL,
    [parol] NVARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

INSERT INTO Admins values ('admin','admin');

CREATE TABLE [dbo].[results] (
    [id]           INT            IDENTITY (1, 1) NOT NULL,
    [studentName]  NVARCHAR (100) NOT NULL,
    [studentGroup] NVARCHAR (100) NOT NULL,
    [testname]     NVARCHAR (100) NOT NULL,
    [ball]         NVARCHAR (20)  NOT NULL,
    [date_time]    NVARCHAR (30)  NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[Tests] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [subject] NVARCHAR (50) NOT NULL,
    [count]   INT           NOT NULL,
    [time]    NCHAR (10)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


