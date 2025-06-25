--Task 1
SELECT * 
FROM Book;

--Task 2
SELECT [Name] + ' ' + [Surname] 
FROM Author;

--Task 3
SELECT DISTINCT Country 
FROM Author
ORDER BY Country;

--Task 4
SELECT BookId
	, Title
	, Price * 0.95 AS DiscountedPrice 
FROM Book
ORDER BY Price DESC, Title;

--Task 5
SELECT AuthorId 
	, Title
	, COUNT(*) AS BookCount
FROM Book
GROUP BY AuthorId, Title;

--Task 6
SELECT COUNT(*) AS BookQuantity
	, MAX(Price) AS MaxPrice
	, MIN(Price) AS MinValue
	, AVG(Price) AS AvgValue
FROM Book;

--Task 7
SELECT Genre AS GenreName
	, MAX(Price) AS MaxPrice
	, MIN(Price) AS MinPrice
	, COUNT(*) AS BookCount
FROM Book
GROUP BY Genre;