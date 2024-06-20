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


-- QUESTION 14
SELECT 

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


