USE Northwind
GO

--1--
CREATE VIEW view_product_order_marc
AS
SELECT p.ProductID, p.ProductName, SUM(od.Quantity) OrderedQuantity
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductID, p.ProductName
ORDER BY p.ProductID

GO

--2--
CREATE PROCEDURE usp_product_order_quantity_marc
	@ProductID INT,
	@TotalQuantity INT OUTPUT
AS
BEGIN
SELECT @TotalQuantity = SUM(Quantity)
FROM [Order Details]
WHERE ProductID = @ProductID
END

GO

--3--
CREATE PROCEDURE usp_product_order_city_marc
	@ProductName NVARCHAR(40)
AS
BEGIN
	SELECT TOP 5 o.ShipCity AS City, SUM(od.Quantity) AS TotalQuantity
	FROM Orders o
	JOIN [Order Details] od ON o.OrderID = od.OrderID
	JOIN Products p ON p.ProductID = od.ProductID
	WHERE p.ProductName = @ProductName
	GROUP BY o.ShipCity
	ORDER BY TotalQuantity DESC
END

--4--
CREATE TABLE people_marc (
	Id INT,
	Name NVARCHAR(50),
	City INT
)
CREATE TABLE city_marc (
	Id INT,
	City NVARCHAR(50)
)
INSERT INTO city_marc VALUES (1, 'Seattle')
INSERT INTO city_marc VALUES (2, 'Green Bay')

INSERT INTO people_marc VALUES (1, 'Aaron Rodgers', 2)
INSERT INTO people_marc VALUES (2, 'Russell Wilson', 1)
INSERT INTO people_marc VALUES (3, 'Jody Nelson', 2)

DELETE FROM city_marc WHERE City = 'Seattle'

INSERT INTO city_marc VALUES (3, 'Madison')
UPDATE people_marc
SET City = 3 WHERE City = 1

GO

CREATE VIEW Packers_marc
AS
SELECT Name FROM people_marc WHERE City = 2

GO
DROP table people_marc
DROP table city_marc
DROP view Packers_marc

GO
--5--
CREATE PROCEDURE usp_birthday_employees_marc 
AS
BEGIN
	CREATE TABLE birthday_employees_marc (
	Id INT PRIMARY KEY,
	FirstName NVARCHAR(50),
	LastName NVARCHAR(50),
	BirthDate DATETIME
	)
	INSERT INTO birthday_employees_marc (Id, FirstName, LastName, BirthDate)
	SELECT EmployeeID, FirstName, LastName, BirthDate
	FROM Employees
	WHERE MONTH(BirthDate) = 2
END

EXECUTE usp_birthday_employees_marc
SELECT * FROM birthday_employees_marc
DROP TABLE birthday_employees_marc

--6--
/*EXCEPT can be used

SELECT * FROM TableA
EXCEPT
SELECT * FROM TableB

This query should only return rows if they're not identical
*/