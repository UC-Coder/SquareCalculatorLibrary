CREATE TABLE Products (
Id INT PRIMARY KEY, 
"ProductName" TEXT
);


CREATE TABLE Categories (
Id INT PRIMARY KEY,
"CategoryName" TEXT
);


CREATE TABLE CommonTable (
ProductId INT FOREIGN KEY REFERENCES Products(Id),
CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
PRIMARY KEY (ProductId, CategoryId)
);


INSERT INTO Products
VALUES
(1, 'Apple'),
(2, 'Pear'),
(3, 'Cucumber'),
(4, 'Tomato'),
(5, 'Jerusalem artichoke');


INSERT INTO Categories
VALUES
(1, 'Fruits'),
(2, 'Vegetables'),
(3, '');


INSERT INTO CommonTable
VALUES
(1, 1),
(2, 1),
(3, 2),
(4, 2),
(5, 3);


SELECT P."ProductName",
       C."CategoryName"
FROM Products AS P
LEFT JOIN CommonTable AS CT ON 
P.Id = CT.ProductId
LEFT JOIN Categories AS C ON 
CT.CategoryId = C.Id;