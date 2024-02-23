USE master;
GO

-- Veritabanını oluştur
CREATE DATABASE KodlamaioCourse;
GO

-- KodlamaioCourse veritabanına geç
USE KodlamaioCourse;
GO

-- Categories tablosunu oluştur
CREATE TABLE Categories
(
    CategoryId INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(255) NOT NULL
);
GO

-- Instructors tablosunu oluştur
CREATE TABLE Instructors
(
    InstructorId INT IDENTITY(1,1) PRIMARY KEY,
    InstructorName NVARCHAR(255) NOT NULL,
    InstructorLastname NVARCHAR(255) NOT NULL,
    InstructorEmail NVARCHAR(255) NOT NULL
);
GO

-- Courses tablosunu oluştur
CREATE TABLE Courses
(
    CourseId INT IDENTITY(1,1) PRIMARY KEY,
    CategoryId INT FOREIGN KEY REFERENCES Categories(CategoryId),
    InstructorId INT FOREIGN KEY REFERENCES Instructors(InstructorId),
    CourseName NVARCHAR(255) NOT NULL,
    CourseDescription NVARCHAR(MAX),
    Price DECIMAL(10, 2) NOT NULL
);
GO
