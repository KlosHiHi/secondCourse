--Task 1
SELECT * 
FROM Book
WHERE Genre = 'проза' AND 
	Price BETWEEN 500 AND 1000;

--Task 2
SELECT Surname, Name, Phone
FROM Customer
WHERE Phone IS NOT NULL;

--Task 3
SELECT *
FROM Book
WHERE Title LIKE '%Поэзия фольги%';

--Task 4
SELECT Title
FROM Book
WHERE Title LIKE 'П%';

--Task 5
SELECT Country
	, COUNT(*) AS AuthorQuantity
FROM Author
GROUP BY Country
HAVING COUNT(*) > 1;

--Task 6
SELECT OrderId
	, SUM(Quantity) AS BooksQuantity
FROM OrderedBook
GROUP BY OrderId 
HAVING SUM(Quantity) > 5;

--Task 7
SELECT AuthorId
	, Title
	, COUNT(*) AS BookQuantity
FROM Book
GROUP BY AuthorId, Title
HAVING COUNT(*) > 1;