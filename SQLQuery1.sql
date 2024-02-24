USE KodlamaioCourse; -- Veritabanınızın adını doğru bir şekilde güncelleyin

CREATE TABLE Orders
(
    OrderId INT PRIMARY KEY,
    InstructorId INT,
    EmployeeId INT,
    OrderDate DATETIME,
    ShipCity NVARCHAR(255)
);
