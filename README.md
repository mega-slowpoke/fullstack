## SQL Basic

#### WHERE vs HAVING
Similarity: Both are used to filter the record

Diff:

1. HAVING applies to group as a whole (multiple rows). WHERE is applied to individual rows 
2. WHERE executes before GROUP BY but HAVING executes after GROUP BY
3. WHERE can be used with select, update, and delete

### DROP vs. TRUNCATE vs. DELETE
1. DELETE is DML, DROP and TRUNCATE are DDLs
    `DROP TABLE ...`
    `TRUNCATE TABLE ...`
    `DELETE FROM ... WHERE ...`
2. DROP will remove the entire table (this table will not exist any more). TRUNCATE and DELETE will just remove data in the table.
3. DELETE will not reset property value while TRUNCATE will


### IDENTITY (AUTO_INCREMEMT)
we cannot insert a row with explicit value of identity column unless we set IDENTITY_INSERT on

## SQL EXECUTION ORDER

    SELECT
    FROM JOIN
    WHERE
    GROUP BY
    HAVING
    ORDER BY

FROM/JOIN --> WHERE --> GROUP BY --> HAVING --> SELECT --> DISTINCT --> ORDER BY

&ensp;&ensp;&ensp;|_______________________________________________|


&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;cannot use alias in select

## Subquery
### JOIN vs. Subquery
1. Join can only be used from clause but subquery can be used anywhere (ORDER BY, WHERE, HAVING)
2. Subquery is easy to maintain and understand
3. Join has better performance most of the time

#### Physical join
1. hash join
2. merge join
3. nested loop join
SQL has optimzer for all joins, that's why it is 

#### correlated subquery (optional)
However, there is one case where subquery outpeforms join. That is join used ***GROUP BY***. 

A correlated subquery can get the same result without GROUP BY. GROUP BY is so expensive that it makes join way less efficient

Correlated subquery: an inner query dependent on the outer query


### UNION vs. UNION ALL
Similarity:
1. number of columns should be same
2. data type should be the same

Diff:
1. union will remove duplicates
2. union will sort the first column ascedening automactially
3. union cannot used be in recursively cte


## Window Function

window function can only used in SELECT OR ORDER BY clauses

### RANK
    SELECT ..., RANK() OVER(ORDER BY ...) AS RNK

there will be a value gap when there is a tie

    Product     SoldNum     RNK
    Shoe          100        1
    T-Shirt       100        1
    Hat            72        3  (value gap 1->3)

### DENSE_RANK
it can avoid value gap

### ROW_NUMBER
    SELECT ..., ROW_NUMBER() OVER(ORDER BY ...) AS RowNum

get the current row number

### Partition By
partition table into different parts, each part has its own rank

    SELECT ..., RANK() OVER(PARTION BY ... ORDER BY ...)


## derived table vs. cte
A subquery after in a FROM clause we have to give derived table an alias
    
    SELECT *
    FROM (SELECT ... FROM ...) AS dt

cte: common table experssion (just a temporary table set). It can make sql query easier to read
    
    WITH cte
    AS (SELECT ... FROM ...)

    SELECT * 
    FROM customer c JOIN cte ON ... 

1. A cte has to be used in the next SELECT query right away. 
2. A cte has to be used in the same batch

### recursive cte
recursive cte is useful when it comes to hierarchy structure



## temp table

### local temp table
only can be seen in the current session (connection)

### global temp table
can be seen in all session, but it can only be modified by the connection creates global temp table


## View
Just a virtual table

lifescope: persisted in the database as long as you do not drop them



## stored procedure
a prepared sql query that we can save in our database and reuse it whenever we want to

lifescope: persisted in the database as long as you do not drop them

Advantages:
1. can be reused so we can reduce duplicate code
2. sp can be used to prevent sql injection becuase it can take parameters.


### trigger
a special type of stored procedure that will automaically run when there is an event that occurs. 

--DML trigger
--DDL trigger
--LogON trigger




## FUNCTIONS


## stored procedure vs. user defined function
1. Usuage: use sp for DML statements and udf for calculations
2. How to call: exec sp, udf are used in sql statements
3. input/output: sp may or may not have input or output params but for udf, it may or may not have input params but it must have output 
4. you can use sp to call a udf, but you can not use udf to call sp.


## Constraints

### primary key vs. unique constraint
1. unique key can be null but primary key cannot
2. One table can have multiple unique keys but only one primary key
3. Primary key will sort the data by default in ascending order but unique key will not. 
4. pk will create a clustered index and unique key will create a non clustered index


## Transcation

### ACID


### Concurrency Problem

|        |    Dirty Read   |   Unreapetable Read     |  Phantom Read      |
|  ----  | ----  |  ----  | ----  | 
|  Read uncommitted  | √  |  √  | √  |
|  Read committed (default) | ×  |  √  | √  |
|  Repeatable read  | ×  |  ×  | √  |
|  Serializable  | × |  ×  | ×  | 