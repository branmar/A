--AdventureWorks2019--
USE AdventureWorks2019
GO

--1--
SELECT c.Name Country, s.Name Province
FROM Person.CountryRegion c JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode

--2--
SELECT c.Name Country, s.Name Province
FROM Person.CountryRegion c JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name IN ('Germany', 'Canada')
ORDER BY c.Name

--Northwind--
USE Northwind
GO

--3--
SELECT DISTINCT
	p.ProductName
FROM 
	Products p 
	JOIN [Order Details] od
	ON p.ProductID = od.ProductID
	JOIN Orders o
	ON o.OrderID = od.OrderID
WHERE
	o.OrderDate > DATEADD(year, -25, GETDATE())
ORDER BY
	p.ProductName

--4--
SELECT TOP 5
	o.ShipPostalCode,
	COUNT(o.OrderDate) AS Sales
FROM 
	[Order Details] od
	JOIN Orders o
	ON o.OrderID = od.OrderID
WHERE
	o.OrderDate > DATEADD(year, -25, GETDATE())
GROUP BY
	o.ShipPostalCode
ORDER BY
	Sales DESC

--5--
SELECT DISTINCT City, COUNT(CompanyName) AS Customers
FROM Customers
GROUP BY City

--6--
SELECT DISTINCT City, COUNT(CompanyName) AS Customers
FROM Customers
GROUP BY City
HAVING COUNT(CompanyName) > 2

--7--
SELECT
	c.CompanyName,
	SUM(od.Quantity) AS ProductsBought
FROM
	Orders o
	JOIN [Order Details] od
	ON o.OrderID = od.OrderID
	JOIN Customers c
	ON c.CustomerID = o.CustomerID
GROUP BY 
	c.CompanyName

--8--
SELECT
	o.CustomerID,
	SUM(od.Quantity) AS ProductsBought
FROM
	Orders o
	JOIN [Order Details] od
	ON o.OrderID = od.OrderID
GROUP BY 
	o.CustomerID
HAVING 
	SUM(od.Quantity) > 100

--9--
SELECT su.CompanyName, sh.CompanyName
FROM Suppliers su JOIN Shippers sh ON su.SupplierID = su.SupplierID
ORDER BY su.CompanyName

--10--
SELECT
	o.OrderDate,
	p.ProductName
FROM 
	Products p 
	JOIN [Order Details] od
	ON p.ProductID = od.ProductID
	JOIN Orders o
	ON o.OrderID = od.OrderID
ORDER BY
	o.OrderDate

--11--
SELECT
	e1.Title,
	e1.FirstName + ' ' + e1.LastName AS Employee1,
	e2.FirstName + ' ' + e2.LastName AS Employee2
FROM
	Employees e1
	JOIN Employees e2
	ON e1.Title = e2.Title
WHERE 
	e1.EmployeeID != e2.EmployeeID

--12--

SELECT m.EmployeeID, FirstName + ' ' + LastName AS Name
FROM Employees m
WHERE (SELECT COUNT(EmployeeID) FROM Employees WHERE m.EmployeeID = ReportsTo) > 2

--13--
SELECT City, CompanyName, ContactName, 'Customer' AS Type
FROM Customers
UNION ALL
SELECT City, CompanyName, ContactName, 'Supplier' AS Type
FROM Customers

--14--
SELECT DISTINCT c.City
FROM Customers c 
	JOIN Employees e
	ON c.City = e.City

--15--
--a--
SELECT c.City
FROM Customers c
WHERE c.City NOT IN 
	(SELECT City FROM Employees)

--b--

SELECT DISTINCT c.City 
FROM Customers c LEFT JOIN Employees e ON e.City=c.City
WHERE e.City IS NULL

--16--
SELECT p.ProductID, p.ProductName, SUM(o.Quantity) AS TotalQuantity
FROM Products p
	JOIN [Order Details] o
	ON o.ProductID = p.ProductID
GROUP BY p.ProductID, p.ProductName

--17--
--a--
SELECT City 
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2

--b--
SELECT DISTINCT c.City
FROM Customers c
WHERE 
	(SELECT COUNT(CustomerID)
	FROM Customers
	WHERE City = c.City) >= 2

--18--
SELECT DISTINCT c.City
FROM Customers c
	JOIN Orders o
	ON c.CustomerID = o.CustomerID
	JOIN [Order Details] od
	ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >= 2

--19--
SELECT TOP 5
	od.ProductID,
	p.ProductName,
	AVG(od.UnitPrice) AS AveragePrice,
	(
	SELECT TOP 1 c.City
	FROM Orders o
		JOIN Customers c
		ON c.CustomerID = o.CustomerID
		JOIN 
			(SELECT OrderID, Quantity FROM [Order Details] WHERE ProductID = od.ProductID) AS od2
		ON od2.OrderID = o.OrderID
	GROUP BY c.City
	ORDER BY SUM(od2.Quantity) DESC
	) AS CityWithMostOrdered
FROM 
	Products p
	JOIN [Order Details] od
	ON p.ProductID = od.ProductID
GROUP BY
	od.ProductID,
	p.ProductName
ORDER BY
	SUM(od.Quantity)

--20--
SELECT 
	dt1.ShipCity
FROM
	(
	SELECT TOP 1 o.ShipCity, COUNT(o.OrderID) MostOrders
	FROM Orders o 
	GROUP BY o.ShipCity
	ORDER BY MostOrders DESC
	) AS dt1 
	JOIN 
	(
	SELECT TOP 1 o.ShipCity, SUM(od.Quantity) TotalQuantity
	FROM Orders o 
		JOIN [Order Details] od 
		ON o.OrderID = od.OrderID
	GROUP BY o.ShipCity
	ORDER BY TotalQuantity DESC
	) AS dt2 
	ON dt1.ShipCity = dt2.ShipCity

--21--
--UNION--
--DISTINCT--