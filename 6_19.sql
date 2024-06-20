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
WHERE Shelf IS NOT NULL
GROUP BY ProductID, Shelf

-- QUESTION 10
-- QUESTION 11
-- QUESTION 12
-- QUESTION 13
-- QUESTION 14
-- QUESTION 15
-- QUESTION 16
-- QUESTION 17
-- QUESTION 18
-- QUESTION 19
-- QUESTION 20
-- QUESTION 21
-- QUESTION 22
-- QUESTION 23
-- QUESTION 24
-- QUESTION 25
-- QUESTION 26
-- QUESTION 27


-- QUESTION 5
-- QUESTION 5
-- QUESTION 5
-- QUESTION 5
-- QUESTION 5
-- QUESTION 5
-- QUESTION 5
-- QUESTION 5


