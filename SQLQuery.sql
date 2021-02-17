CREATE TABLE Colors(
	ColorID int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(25),
)
CREATE TABLE Brands(
	BrandID int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(25),
)

CREATE TABLE Cars(
	ID int PRIMARY KEY IDENTITY(1,1),
	BrandID int,
	ColorID int,
	ModelYear nvarchar(25),
	DailyPrice decimal,
	Description nvarchar(25),
	FOREIGN KEY (ColorID) REFERENCES Colors(ColorID),
	FOREIGN KEY (BrandID) REFERENCES Brands(BrandID)
)


INSERT INTO Cars(BrandID,ColorID,ModelYear,DailyPrice,Description)
VALUES
	('1','1','2012','100','Manuel Benzin'),
	('1','3','2015','150','Otomatik Dizel'),
	('2','1','2017','200','Otomatik Hybrid'),
	('3','3','2014','125','Manuel Dizel');

INSERT INTO Colors(ColorName)
VALUES
	('Kýrmýzý'),
	('Mavi'),
	('Yeþil'),
	('Siyah'),
	('Beyaz');


INSERT INTO Brands(BrandName)
VALUES
	('BMW'),
	('Audi'),
	('Renault'),
	('Peugeot'),
	('Opel'),
	('Mercedes'),
	('Toyota');