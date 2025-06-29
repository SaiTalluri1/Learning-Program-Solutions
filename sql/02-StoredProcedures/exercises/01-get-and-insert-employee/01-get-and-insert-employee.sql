-- Stored Procedure to retrieve employees by department
DELIMITER //
CREATE PROCEDURE GetEmployeesByDepartment(IN dept_id INT)
BEGIN
    SELECT * FROM Employees WHERE DepartmentID = dept_id;
END;
//
DELIMITER ;

-- Stored Procedure to insert a new employee
DELIMITER //
CREATE PROCEDURE sp_InsertEmployee(
    IN FirstName VARCHAR(50),
    IN LastName VARCHAR(50),
    IN DepartmentID INT,
    IN Salary DECIMAL(10,2),
    IN JoinDate DATE
)
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (FirstName, LastName, DepartmentID, Salary, JoinDate);
END;
//
DELIMITER ;

-- Call Examples
CALL GetEmployeesByDepartment(3);
CALL sp_InsertEmployee('Ravi', 'Kumar', 3, 7500.00, '2023-08-20');
