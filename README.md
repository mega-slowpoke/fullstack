### SQL Basic

#### WHERE vs HAVING
Similarity: Both are used to filter the record

Diff:

1. HAVING applies to group as a whole (multiple rows). WHERE is applied to individual rows 
2. WHERE executes before GROUP BY but HAVING executes after GROUP BY
3. WHERE can be used with select, update, and delete



### SQL EXECUTION ORDER

    SELECT
    FROM JOIN
    WHERE
    GROUP BY
    HAVING
    ORDER BY

FROM/JOIN --> WHERE --> GROUP BY --> HAVING --> SELECT --> DISTINCT --> ORDER BY

&ensp;&ensp;&ensp;|_______________________________________________|


&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;&ensp;cannot use alias in select


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


#### derived table
A subquery after in a FROM clause we have to give derived table an alias


### UNION vs. UNION ALL
Similarity:
1. number of columns should be same
2. data type should be the same

Diff:
1. union will remove duplicates
2. union will sort the first column ascedening automactially
3. union cannot used be in recursively cte


## Window Function