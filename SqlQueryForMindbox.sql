CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100)
);

CREATE TABLE Categories (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100)
);

CREATE TABLE ProductsCategories (
    ProductId INT FOREIGN KEY REFERENCES Products(Id),
    CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
    PRIMARY KEY (ProductId, CategoryId)
);

SELECT Products.name, Catagories.Name
FROM Products LEFT JOIN Caragories ON Products.Id=Caragories.Id
ORDER BY Products.name;