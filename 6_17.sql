-- QUESTION 1 
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product

-- QUESTION 2
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice <> 0

-- QUESTION 3
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color is NULL

-- QUESTION 4
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color is NOT NULL

-- QUESTION 5
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color is NOT NULL AND ListPrice > 0

-- QUESTION 6
SELECT Name + ' ' + Color
FROM Production.Product
WHERE Color is NOT NULL

-- QUESTION 7
SELECT 'NAME: ' + Name + ' -- COLOR: ' + Color AS NameAndColor
FROM Production.Product
WHERE (Name LIKE '% Crankarm' OR Name LIKE 'Chainring%') AND Color IN ('Black', 'Silver') 

-- QUESTION 8
SELECT ProductID, Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500

-- QUESTION 9
SELECT ProductID, Name, Color
FROM Production.Product
WHERE Color = 'Black' OR Color = 'Blue'

-- QUESTION 10
SELECT ProductID, Name, Color
FROM Production.Product
WHERE Name LIKE 'S%'

-- QUESTION 11
SELECT Name, ListPrice
FROM Production.Product
ORDER BY Name

-- QUESTION 12
SELECT Name
FROM Production.Product
WHERE Name LIKE '[AS]%'
ORDER BY Name

-- QUESTION 13
SELECT Name
FROM Production.Product
WHERE Name LIKE 'SPO[^K]%'
ORDER BY Name

-- QUESTION 14
SELECT DISTINCT Color
FROM Production.Product
ORDER BY Color DESC

-- QUESTION 15
-- it doesn't specify in what way we should sort the data
-- So I just sort by id and color(if ids are the same)
SELECT DISTINCT ProductSubcategoryID, Color
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL AND Color IS NOT NULL
ORDER BY ProductSubcategoryID, Color