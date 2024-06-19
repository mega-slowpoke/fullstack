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