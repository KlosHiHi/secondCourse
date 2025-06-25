-- TASK1
UPDATE Book
SET Price = ROUND(Price, -1);

-- TASK2
SELECT COUNT(*) as Quantity
	, YEAR(OrderDate) as Year
	, MONTH(OrderDate) as Month
FROM [Order]
GROUP BY YEAR(OrderDate)
	, MONTH(OrderDate)
ORDER BY YEAR(OrderDate) DESC
	, MONTH(OrderDate) DESC;

-- TASK3
UPDATE Book
SET Price = Book.Price * 0.9
FROM Book
WHERE (Book.BookId IN (
	SELECT Book.BookId
	FROM [Order] JOIN
		OrderedBook ON [Order].OrderId = OrderedBook.OrderId RIGHT JOIN
		Book ON OrderedBook.BookId = Book.BookId
WHERE (YEAR([Order].OrderDate) <> YEAR(GETDATE())))
);

-- TASK4
SELECT CustomerId
	, UPPER(Surname + ' ' + LEFT([Name], 1) + '.') AS CustomerInfo
FROM Customer;

-- TASK5
UPDATE Customer
	SET Login = REPLACE(TRIM(Login), ' ', '_');

-- TASK6
SELECT CustomerId
	, Surname
	, ISNULL(Phone, '-') AS Phone
	, NULLIF([Address], '') AS [Address]
FROM Customer;

-- TASK7
SELECT DISTINCT STRING_AGG(Book.Title, ', ') AS AllTitles
FROM Book JOIN
	Author ON Book.AuthorId = Author.AuthorId
GROUP BY Author.Name
ORDER BY AllTitles;

-- TASK8
SELECT OrderedBook.OrderId
	, STRING_AGG(Author.Surname + ' ' + Book.Title, ', ') AS [Name]
FROM Book INNER JOIN
	Author ON Book.AuthorId = Author.AuthorId INNER JOIN
	OrderedBook ON Book.BookId = OrderedBook.BookId
GROUP BY OrderedBook.OrderId;

-- TASK9
SELECT Title
	, ROW_NUMBER() OVER (ORDER BY Book.Title) AS RowNumber
FROM Book;

-- TASK10
SELECT Title
, Genre
, ROW_NUMBER() OVER (PARTITION BY Genre ORDER BY Title) AS RowNumber
FROM Book;