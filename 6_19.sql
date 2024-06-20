USE AdventureWorks2019
GO
-- QUESTION 1
SELECT COUNT(ProductID) AS TotalNum
FROM Production.Product

-- QUESTION 2
SELECT COUNT(ProductID) AS TotalNum
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL

-- QUESTION 3
SELECT ProductSubcategoryID, COUNT(ProductID) AS TotalNum
FROM Production.Product
GROUP BY ProductSubcategoryID
HAVING ProductSubcategoryID IS NOT NULL

-- QUESTION 4
SELECT COUNT(ProductID) AS TotalNum
FROM Production.Product
WHERE ProductSubcategoryID IS NULL

-- QUESTION 5
SELECT SUM(Quantity)
FROM Production.ProductInventory

-- QUESTION 6
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40 
GROUP BY ProductID
HAVING SUM(Quantity) < 100

-- QUESTION 7
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40 
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100

-- QUESTION 8
SELECT ProductID, AVG(Quantity) AS Average
FROM Production.ProductInventory
WHERE LocationID = 10
GROUP BY ProductID

-- QUESTION 9
SELECT ProductID, Shelf, AVG(Quantity) AS Average
FROM Production.ProductInventory
GROUP BY ProductID, Shelf


-- QUESTION 10
SELECT ProductID, Shelf, AVG(Quantity) AS Average
FROM Production.ProductInventory
WHERE NOT Shelf = 'N/A'
GROUP BY ProductID, Shelf

-- QUESTION 11
SELECT Color, Class, COUNT(ProductID) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class

-- QUESTION 12
SELECT cr.Name AS CountryRegion, sp.Name AS StateProvince
FROM Person.CountryRegion cr 
	LEFT JOIN Person.StateProvince sp 
	ON cr.CountryRegionCode = sp.CountryRegionCode 

-- QUESTION 13
SELECT cr.Name AS CountryRegion, sp.Name AS StateProvince
FROM Person.CountryRegion cr 
	LEFT JOIN Person.StateProvince sp 
	ON cr.CountryRegionCode = sp.CountryRegionCode 
WHERE cr.Name IN ('Germany', 'Canada')


USE Northwind
GO
-- QUESTION 14
SELECT p.ProductName
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON o.OrderID = od.OrderID 
WHERE YEAR(GETDATE()) - YEAR(o.OrderDate) <= 27
GROUP BY p.ProductName

-- QUESTION 15
SELECT TOP 5 ShipPostalCode, COUNT(ShipPostalCode)
FROM Orders 
GROUP BY ShipPostalCode
ORDER BY COUNT(ShipPostalCode) DESC

-- QUESTION 16
SELECT TOP 5 ShipPostalCode, COUNT(ShipPostalCode)
FROM Orders
WHERE YEAR(GETDATE()) - YEAR(OrderDate) <= 27
GROUP BY ShipPostalCode
ORDER BY COUNT(ShipPostalCode) DESC

-- QUESTION 17
SELECT City, COUNT(*) AS CustomerNum
FROM Customers
GROUP BY City

-- QUESTION 18
SELECT City, COUNT(*) AS CustomerNum
FROM Customers
GROUP BY City
HAVING COUNT(*) >= 2

-- QUESTION 19
SELECT c.CompanyName
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > '1998-01-01'
GROUP BY c.CompanyName

-- QUESTION 20
SELECT c.CompanyName, MAX(o.OrderDate) AS RecentOrderDate
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.CompanyName

-- QUESTION 21
SELECT c.CompanyName, COUNT(*) AS OrderNum
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.CompanyName

-- QUESTION 22
SELECT c.CustomerID, COUNT(*) AS OrderNum
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.CustomerID
HAVING COUNT(*) > 100

-- QUESTION 23
SELECT su.CompanyName AS 'Supplier Company Name', sh.CompanyName AS 'Shipping Company Name'
FROM Shippers sh
CROSS JOIN Suppliers su

-- QUESTION 24
SELECT o.OrderDate, p.ProductName
FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID JOIN Products p ON p.ProductID = od.ProductID
GROUP BY o.OrderDate, p.ProductName
ORDER BY o.OrderDate, p.ProductName

-- QUESTION 25
SELECT 
    e1.LastName + ' ' + e1.FirstName  AS Employee1,
    e2.LastName + ' ' + e2.FirstName  AS Employee2,
    e1.Title
FROM Employees e1 JOIN Employees e2 ON e1.Title = e2.Title AND e1.EmployeeID < e2.EmployeeID

-- QUESTION 26
SELECT manager.EmployeeID
FROM Employees report LEFT JOIN Employees manager ON report.ReportsTo = manager.EmployeeID
GROUP BY manager.EmployeeID
HAVING COUNT(manager.EmployeeID) > 2

-- QUESTION 27
SELECT City, CompanyName AS Name, ContactName, 'Customer' AS Type
FROM Customers 
UNION
SELECT City, CompanyName AS Name, ContactName, 'Supplier' AS Type
FROM Suppliers
ORDER BY City