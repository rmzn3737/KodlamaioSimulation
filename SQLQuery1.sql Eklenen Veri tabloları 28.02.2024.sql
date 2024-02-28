USE KodlamaioCourse;

CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(50) NOT NULL,
    PasswordHash VARBINARY(500) NOT NULL,
    PasswordSalt VARBINARY(500) NOT NULL,
    Status BIT
);
USE KodlamaioCourse;

CREATE TABLE OperationClaims (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Name NVARCHAR(250) NOT NULL
);
USE KodlamaioCourse;

CREATE TABLE UserOperationClaims (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    UserId INT NOT NULL,
    OperationClaimId INT NOT NULL
    
);

