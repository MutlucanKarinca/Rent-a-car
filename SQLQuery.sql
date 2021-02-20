CREATE TABLE Colors(
	ColorID int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(25),
)
CREATE TABLE Brands(
	BrandID int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(25),
)

CREATE TABLE Customers(
	ID int PRIMARY KEY IDENTITY(1,1),
	UserID int,
	CompanyName nvarchar(25),
	FOREIGN KEY (UserID) REFERENCES Users(ID)
)

CREATE TABLE Rentals(
	ID int PRIMARY KEY IDENTITY(1,1),
	CarId int,
	CustomerId int,
	RentDate datetime,
	ReturnDate datetime,
	FOREIGN KEY (CarID) REFERENCES Cars(CarID),
	FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
)

CREATE TABLE Users(
	ID int PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(50)
	LastName nvarchar(50)
	Email nvarchar(50)
	Password nvarchar(50),
)

CREATE TABLE Cars(
	CarID int PRIMARY KEY IDENTITY(1,1),
	BrandID int,
	ColorID int,
	ModelYear nvarchar(25),
	DailyPrice decimal,
	Description nvarchar(25),
	CarName nvarchar(25),
	FOREIGN KEY (ColorID) REFERENCES Colors(ColorID),
	FOREIGN KEY (BrandID) REFERENCES Brands(BrandID)
)


