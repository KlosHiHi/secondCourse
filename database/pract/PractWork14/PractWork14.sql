--Task 1
SELECT Book.BookId
	, Book.Title
	, Author.Surname
	, Author.[Name]
	, Book.Price
FROM Book
	JOIN Author ON Book.AuthorId = Author.AuthorId;

--Task 2
SELECT OrderedBook.OrderId
	, Book.BookId
	, Book.Title
	, Author.Surname
	, Author.[Name]
	, Book.Price 
	, OrderedBook.Quantity 
	, Book.Price * OrderedBook.Quantity AS TotalPrice
FROM Book
	JOIN Author ON Book.AuthorId = Author.AuthorId
	JOIN OrderedBook ON Book.BookId = OrderedBook.BookId;

--Task 3
SELECT [Order].OrderId
	, [Order].OrderDate
	, Sum(Book.Price * OrderedBook.Quantity) AS TotalPrice
FROM OrderedBook
	JOIN Book ON Book.BookId = OrderedBook.BookId
	JOIN [Order] ON [Order].OrderId = OrderedBook.OrderId
GROUP BY [Order].OrderId
	, [Order].OrderDate
ORDER BY OrderDate DESC;

--Task 4
SELECT Customer.CustomerId
	, Customer.[Login]
	, COUNT([Order].CustomerId) AS OrderQuantity
FROM Customer
	LEFT JOIN [Order] ON Customer.CustomerId = [Order].CustomerId
GROUP BY Customer.CustomerId
	, Customer.[Login];

--Task 5
SELECT *
FROM [Order]
WHERE OrderId NOT IN(
	SELECT DISTINCT OrderId
	FROM OrderedBook);

--Task 6
SELECT *
FROM Customer
WHERE Customer.CustomerId IN (
	SELECT DISTINCT CustomerId
	FROM [Order]
	);

--Task 7
SELECT Author.Surname
	, Author.[Name]
	, 'Author' AS category
FROM Author
UNION ALL
SELECT Customer.Surname
	, Customer.[Name]
	, 'Customer' AS category
FROM Customer
ORDER BY Surname
	, [Name];