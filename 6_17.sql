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
