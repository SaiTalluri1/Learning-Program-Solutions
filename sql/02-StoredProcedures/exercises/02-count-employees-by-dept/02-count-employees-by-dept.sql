-- Stored Procedure to count employees by department
DELIMITER //
CREATE PROCEDURE sp_CountEmployeesByDepartment(IN dept_id INT)
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = dept_id;
END;
//
DELIMITER ;

-- Call Example
CALL sp_CountEmployeesByDepartment(3);
