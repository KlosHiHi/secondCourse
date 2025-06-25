/*
--Task1
INSERT INTO Book(AuthorId, Title, PublicationYear)
VALUES (2, 'Черемша', 2025);

--Task2
DELETE 
FROM Customer
WHERE (Phone IS NULL);

--Task3
UPDATE Book 
SET Price -= 100
WHERE Title LIKE '%Сказки%';
*/

-- Task 4
SELECT Author.Surname, Author.Name, Title, Price, PublicationYear
INTO Prose
FROM Book
	INNER JOIN Author On Book.AuthorId = Author.AuthorId
WHERE Genre = 'проза';

-- Task 5
DELETE [Order]
FROM [Order]
	JOIN OrderedBook ON OrderedBook.OrderId = [Order].OrderId
WHERE OrderedBook.BookId IS NULL;

-- Task 6
UPDATE Book
SET Price += 100
FROM Book
	JOIN Author ON Author.AuthorId = Book.AuthorId
WHERE Author.Country = 'Россия';

-- Task 7
UPDATE Book
SET Price = CASE Genre
			WHEN 'проза' THEN Price * 0.9
			WHEN 'поэзия' THEN Price - 100
			ELSE Price
			END;