-- ROW_NUMBER: Unique rank per category
SELECT ProductName, Category, Price,
       ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
FROM Products;

-- RANK: Ranks with gaps for ties
SELECT ProductName, Category, Price,
       RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum
FROM Products;

-- DENSE_RANK: Ranks without gaps for ties
SELECT ProductName, Category, Price,
       DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankNum
FROM Products;
