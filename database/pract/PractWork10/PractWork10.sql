 -- Task 1
 CREATE TABLE Discount(
	 DiscountId int NOT NULL IDENTITY,
	 Name nvarchar(50) NOT NULL,
	 Description nvarchar(200) NULL,
	 DiscountAmount int NOT NULL,
	 StartDate date DEFAULT GetDate(),
	 EndDate date NULL
	 Primary Key (DiscountId) 
 );

 -- Task 2
CREATE TABLE DiscountProduct(
	DiscountId int NOT NULL,
	BookId int NOT NULL,

	CONSTRAINT PK_DiscountProduct
	PRIMARY KEY (DiscountId, BookId),

	CONSTRAINT FK_Discount_DiscountProduct
	FOREIGN KEY (DiscountId)
	REFERENCES Discount 
	ON DELETE CASCADE
	ON UPDATE CASCADE,

	CONSTRAINT FK_Book_DiscountProduct
	FOREIGN KEY (BookId)
	REFERENCES Book
	ON UPDATE CASCADE
 );

 -- Task 3
 ALTER TABLE Discount
	ADD DiscountType VARCHAR(5) NULL;

 -- Task 4
 ALTER TABLE Discount
	ADD CONSTRAINT DF_DiscountType
	DEFAULT '%' FOR DiscountType;

-- Task 5
ALTER TABLE Discount
	ADD CONSTRAINT CK_Discount_DiscountType
	CHECK (DiscountType = '%' OR DiscountType = 'руб.');

ALTER TABLE Discount
	ADD CONSTRAINT CK_Discount_DiscountAmount
	CHECK (DiscountAmount > 0);

-- Task 6
ALTER TABLE Discount
	ADD CONSTRAINT UQ_Discount_Name_StartDate
	UNIQUE(Name, StartDate)

-- Task 7
ALTER TABLE DiscountProduct
	DROP CONSTRAINT FK_Book_DiscountProduct;

ALTER TABLE DiscountProduct
	DROP CONSTRAINT FK_Discount_DiscountProduct;

DROP TABLE Discount;