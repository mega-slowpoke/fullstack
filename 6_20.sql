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
SELECT p.ProductID, p.ProductName, COUNT(*) AS TotalNum
FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID JOIN Products p ON od.ProductID = p.ProductID 
GROUP BY p.ProductID, p.ProductName

-- QUESTION 4
SELECT c.City, COUNT(*) AS TotalNum
FROM Orders o JOIN Customers c ON c.City = o.ShipCity
GROUP BY c.City

-- QUESTION 5


-- QUESTION 6

-- QUESTION 7

-- QUESTION 8

-- QUESTION 9

-- QUESTION 10

-- QUESTION 11
