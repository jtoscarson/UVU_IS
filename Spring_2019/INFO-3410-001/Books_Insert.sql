-- Inserting Seller Data
INSERT INTO Sellers
VALUES ('Amazon'),
	('Barnes & Noble'),
	('Sam Weller''s');
GO

-- Inserting Publisher Data
INSERT INTO Publishers
VALUES ('Tor Science Fiction'),
	('Disney-Hyperion'),
	('Wiley'),
	('O''Reilly'),
	('Murach & Associates'),
	('Scholastic'),
	('Infinte Publishing');
GO

-- Inserting the Authors data
INSERT INTO Authors
VALUES ('Orson Scott', 'Card'),
	('Rick', 'Riordan'),
	('Ralph', 'Kimball'),
	('Margy', 'Ross'),
	('Sayed M. M.', 'Tahaghoghi'),
	('Hugh', 'Williams'),
	('Bryan', 'Syverson'),
	('Joel', 'Murach'),
	('J.K.', 'Rowling'),
	('Paul', 'DuBois'),
	('Aaron', 'Johnston'),
	('Matthew', 'North'),
	('Laura', 'Reeves'),
	('Warren', 'Thornthwaite');
GO;

SELECT * FROM Authors;
GO;

INSERT INTO Authors
VALUES ('Dr.', 'Seuss');
GO;

--Adding books to our catalog of offerings
INSERT INTO Books
VALUES ('978-0812550702', 'Ender''s Game',     352, '7/15/1994', 5.99, 10000),
	('978-0786838653', 'The Lightning Thief (Percy Jackson and the Olympians, Book 1)', 416, '3/21/2006', 5.29, 11000),
	('978-0812550757', 'Speaker for the Dead', 382, '8/15/1994', 7.99, 10000),
	('978-1118530801', 'The Data Warehouse Toolkit', 600, '7/1/2013', 48.14, 12000),
	('978-0596008642', 'Learning MySQL: Get a Handle on Your Data', 618, '11/24/2006', 29.93, 13000),
	('978-1890774691', 'Murach''s SQL Server 2012 for Developers', 814, '8/20/2012', 40.70, 14000),
	('978-0439708180', 'Harry Potter and the Sorcerer''s Stone', 309, '9/8/1999', 6.85, 15000),
	('978-0439136365', 'Harry Potter and the Prisoner of Azkaban', 448, '9/11/2001', 6.75, 15000),
	('978-1449374020', 'MySQL Cookbook', 866, '8/18/2014', 51.80, 13000),
	('978-0439064873', 'Harry Potter and the Chamber of Secrets', 341, '8/15/2000', 6.85, 15000),
	('978-0765375629', 'The Swarm: The Second Formic War (Volume 1)',    464, '8/2/2016', 12.99, 10000),
	('978-1523321438', 'Data Mining for the Masses', 312, '1/8/2016', 44.99, 16000),
	('978-0471255475', 'The Data Warehouse Lifecycle Toolkit', 800, '8/13/1998', 40.92, 12000);
GO;

SELECT * FROM Publishers;
GO;

-- Inserting the Books with their Authors
INSERT INTO BookAuthors
VALUES ('978-0812550702', 1),
	('978-0786838653', 2),
	('978-0812550757', 1),
	('978-1118530801', 3),
	('978-1118530801', 4),
	('978-0596008642', 5),
	('978-0596008642', 6),
	('978-1890774691', 7),
	('978-1890774691', 8),
	('978-0439708180', 9),
	('978-0439136365', 9),
	('978-1449374020', 10),
	('978-0439064873', 9),
	('978-0765375629', 1),
	('978-0765375629', 11),
	('978-1523321438', 12),
	('978-0471255475', 13),
	('978-0471255475', 4),
	('978-0471255475', 14);
GO;

SELECT * FROM Authors;

--Inserting the books and who sells them
INSERT INTO BookSellers
VALUES ('978-0439064873', 100),
	('978-0439064873', 110),
	('978-0439064873', 120),
	('978-0439136365', 100),
	('978-0439136365', 110),
	('978-0439136365', 120),
	('978-0439708180', 100),
	('978-0439708180', 110),
	('978-0439708180', 120),
	('978-0471255475', 100),
	('978-0596008642', 100),
	('978-0596008642', 110),
	('978-0765375629', 100),
	('978-0765375629', 110),
	('978-0786838653', 100),
	('978-0786838653', 110),
	('978-0786838653', 120),
	('978-0812550702', 100),
	('978-0812550702', 110),
	('978-0812550757', 100),
	('978-0812550757', 110),
	('978-1118530801', 100),
	('978-1118530801', 110),
	('978-1449374020', 100),
	('978-1449374020', 110),
	('978-1449374020', 120),
	('978-1523321438', 100),
	('978-1890774691', 100),
	('978-1890774691', 110);
