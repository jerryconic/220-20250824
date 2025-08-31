USE db01;
GO
DROP TABLE IF EXISTS dbo.Product
CREATE TABLE dbo.Product
(
prdt_id int PRIMARY KEY,
prdt_name nvarchar(20),
price int
);

INSERT INTO dbo.Product(prdt_id, prdt_name, price)
VALUES(1, 'A-Product', 9999);

SELECT * FROM dbo.Product
WHERE prdt_id = 1;

UPDATE dbo.Product
SET prdt_name = 'CPU', price = 9000
WHERE prdt_id = 1;

SELECT * FROM dbo.Product
WHERE prdt_id = 1;

DELETE FROM dbo.Product
WHERE prdt_id = 1;

SELECT * FROM dbo.Product
WHERE prdt_id = 1;