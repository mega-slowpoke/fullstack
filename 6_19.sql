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