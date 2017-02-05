CREATE TABLE [dbo].[Person] (
    [SSN]        CHAR (9)      NOT NULL,
    [FirstName]  NVARCHAR (16) NOT NULL,
    [MiddleName] NVARCHAR (16) NULL,
    [LastName]   NVARCHAR (24) NOT NULL,
    [BirthDate]  SMALLDATETIME NOT NULL,
    [IsDeceased] BIT           NOT NULL,
    CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED ([SSN] ASC)
);

