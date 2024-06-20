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



