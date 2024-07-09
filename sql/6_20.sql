-- QUESTION 1
SELECT DISTINCT CITY 
FROM Employees 
WHERE CITY IN 
(SELECT DISTINCT City FROM Customers)

-- QUESTION 2
---- Use subquery
SELECT DISTINCT City 
FROM Customers
WHERE City NOT IN
(SELECT DISTINCT CITY FROM Employees)
 
---- Don't use subquery
SELECT DISTINCT c.City
FROM Customers c LEFT JOIN Employees e ON c.City = e.City
WHERE e.City IS NULL

-- QUESTION 3
SELECT p.ProductID, p.ProductName, SUM(od.Quantity) AS TotalNum
FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID JOIN Products p ON od.ProductID = p.ProductID 
GROUP BY p.ProductID, p.ProductName

-- QUESTION 4
SELECT c.City, SUM(od.Quantity) AS TotalNum
FROM Orders o JOIN [Order Details] od ON od.OrderID = o.OrderID JOIN Customers c ON c.CustomerID = o.CustomerID
GROUP BY c.City

-- QUESTION 5
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(*) >= 2

-- QUESTION 6
SELECT C.City, COUNT(DISTINCT od.ProductID) AS ProductType
FROM Customers c JOIN Orders o ON o.CustomerID = c.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP BY C.City 
HAVING COUNT(DISTINCT od.ProductID) >= 2

-- QUESTION 7
SELECT DISTINCT c.CustomerID, c.City, o.ShipCity
FROM Customers c JOIN Orders o ON o.CustomerID = c.CustomerID
WHERE c.City <> o.ShipCity

-- QUESTION 8
WITH Top5ProductInfo AS (
SELECT TOP 5 od.ProductID, ROUND(AVG(od.UnitPrice * od.Quantity * (1- od.Discount)), 2) AS AvgPrice
FROM Orders o JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP BY od.ProductID
ORDER BY SUM(od.Quantity) DESC
),

CityQuantities AS (
SELECT od.ProductID, c.City, SUM(od.Quantity) AS CityQuantity, ROW_NUMBER() OVER(PARTITION BY od.ProductID ORDER BY SUM(od.Quantity) DESC) AS RowNum
FROM Orders o JOIN [Order Details] od ON od.OrderID = o.OrderID JOIN Customers c ON c.CustomerID = o.CustomerID
WHERE od.ProductID IN (SELECT ProductID FROM Top5ProductInfo)
GROUP BY od.ProductID, c.City
)

SELECT t.ProductID, t.AvgPrice, c.City
FROM Top5ProductInfo t JOIN CityQuantities c ON t.ProductID = c.ProductID
WHERE c.RowNum = 1

-- QUESTION 9
---- Use sub-query
SELECT DISTINCT City
FROM Employees
WHERE City NOT IN 
(SELECT DISTINCT City 
FROM Customers 
WHERE CustomerID IN (SELECT CustomerID FROM Orders))
---- Do not use sub-query
SELECT e.City
FROM Employees e LEFT JOIN (Customers c JOIN Orders o ON c.CustomerID = o.CustomerID) ON e.City = c.City
WHERE c.CustomerID IS NULL

-- QUESTION 10
With MostOrder AS (
	SELECT e.City, COUNT(o.OrderID) AS TotalOrder, RANK() OVER(ORDER BY COUNT(o.OrderID) DESC) AS RNK
    FROM Orders o JOIN Employees e ON e.EmployeeID = o.EmployeeID
    GROUP BY e.City
),

MostQuantity AS (
	SELECT o.ShipCity, SUM(od.Quantity) AS TotalQuantity, RANK() OVER(ORDER BY SUM(od.Quantity) DESC) AS RNK
	FROM [Order Details] od JOIN Orders o ON o.OrderID = od.OrderID
	GROUP BY o.ShipCity
)

SELECT *
FROM MostOrder o JOIN MostQuantity q ON o.City = q.ShipCity 
WHERE o.RNK = 1 AND q.RNK = 1

-- QUESTION 11
-- We can use DISTINCT keyword, for example
SELECT DISTINCT ShipCity
FROM Orders