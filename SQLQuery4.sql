USE KodlamaioCourse;

CREATE TABLE UserOperationClaims (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    UserId INT NOT NULL,
    OperationClaimId INT NOT NULL
    
);