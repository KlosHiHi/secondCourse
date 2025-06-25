SELECT Game.Id
	, Game.Title
	, STRING_AGG(Review.Comment, ';')
FROM Game INNER JOIN
	Review ON Game.Id = Review.GameId
GROUP BY Game.Id
	, Game.Title;

SELECT GETDATE()  'Текущая дата'
	, YEAR(GETDATE()) 'Текущий год'
	, YEAR('2012-06-14') 'Год из данных'
	, MONTH('2012-06-14') 'Месяц из данных'
	, DAY('2012-06-14') 'День из данных'
	, DATEPART(HH, GETDATE()) 'Текущий час'
	, DATENAME(M, GETDATE()) 'Имя месяцы'
	, DATEADD(D, 20, GETDATE()) 'Дата через 20 дней'
	, DATEPART(DW, DATEADD(d, 1, GETDATE()))
	, DATEADD(D, -30, GETDATE())
	, DATEDIFF(DD, GETDATE(), '2007-10-31')
	, CURRENT_TIMESTAMP;

SELECT Title
	, LEFT(Title, 2)
	, RIGHT(Title, 2)
	, SUBSTRING(Title, 2, 5)
	, LOWER(Title)
	, UPPER(Title)
FROM Game;

SELECT Title
	, QUOTENAME(Title, '<')
	, REPLACE(Title, '222', ' ')
	, CONCAT_WS(' -- ', Price, PublicationYear)
FROM Game;

SELECT Id
	, value
FROM GAME
	CROSS APPLY STRING_SPLIT(Title, ' ');

SELECT GameId
	, STRING_AGG([User], ';') WITHIN GROUP (ORDER BY [User] DESC)
FROM Review
GROUP BY GameId;

SELECT Title
	, HASHBYTES('SHA2_256', Title)
	, HASHBYTES('SHA2_256', Title)
FROM Game;

SELECT *
	, ISNULL([Description], 'meow')
	, NULLIF([Description], '')
FROM Game;

SELECT Price
	, STR(Price, 3, 1)
FROM Game;

SELECT 123.456
	, CAST(123.456 AS decimal(8, 2))
	, CAST(ROUND(123.456, 1) AS decimal(8, 1))

SELECT '14.06.2025'
	, CONVERT(datetime, '14.06.2025', 104);

SELECT ROW_NUMBER() OVER (ORDER By Title)
	, *
FROM Game;

SELECT ROW_NUMBER() OVER (PARTITION BY [User] ORDER By GameId) AS #
	, *
FROM Review;