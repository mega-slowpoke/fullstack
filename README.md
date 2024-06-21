## SQL Basic

#### WHERE vs HAVING
Similarity: Both are used to filter the record

Diff:

1. HAVING applies to group as a whole (multiple rows). WHERE is applied to individual rows 
2. WHERE executes before GROUP BY but HAVING executes after GROUP BY
3. WHERE can be used with select, update, and delete



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