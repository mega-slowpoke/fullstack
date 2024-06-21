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


-- QUESTION 5


-- QUESTION 6
SELECT c.City, od.ProductID, COUNT(*) AS TotalNum
FROM Orders o JOIN Customers c ON c.City = o.ShipCity JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP BY c.City, od.ProductID
HAVING COUNT(*) = 2

-- QUESTION 7
SELECT DISTINCT c.CustomerID, c.City, o.ShipCity
FROM Customers c JOIN Orders o ON o.CustomerID = c.CustomerID
WHERE c.City <> o.ShipCity

-- QUESTION 8
--SELECT dt.ProductID
-- FROM (
-- SELECT od.ProductID, COUNT(od.ProductID), AVG(od.UnitPrice * od.Quantity)
-- FROM Orders o JOIN [Order Details] od ON od.OrderID = o.OrderID
-- GROUP BY od.ProductID
-- ORDER BY COUNT(od.ProductID) DESC
-- ) AS dt

-- QUESTION 9

-- QUESTION 10

-- QUESTION 11
-- We can use DISTINCT keyword