### Features

- N Katmanlı mimari yapısında hazırlanmıştır;
- EntityFramework kullanılarak database ile ilişki kurulmuştur;
- CRUD işlemlerinin yapıldığı araç kiralamaya yönelik bir projedir;
- Projede Autofac, FluentValidation, EntityFramework paketleri vardır;
- SQL tablosunu oluşturmak için [SQL Sorgu](https://github.com/MutlucanKarinca/ReCapProject/blob/main/SQLQuery.sql "SQL Sorgu")


# ReCapProject - Araç Kiralama

![](https://ouch-cdn.icons8.com/preview/263/d597caab-0c13-49be-88d8-b39ab8db1ac0.png)

#[Business](https://github.com/MutlucanKarinca/ReCapProject/tree/main/Business)
#[ConsoleUI](https://github.com/MutlucanKarinca/ReCapProject/tree/main/ConsoleUI )
#[Core](https://github.com/MutlucanKarinca/ReCapProject/tree/main/Core )
#[DataAccess](https://github.com/MutlucanKarinca/ReCapProject/tree/main/DataAccess)
#[Entities](https://github.com/MutlucanKarinca/ReCapProject/tree/main/Entities)
#[WebAPI](https://github.com/MutlucanKarinca/ReCapProject/tree/main/WebAPI)



#SQL Tables
> **Brands**
                    
Column Name  | Data Type
------------- | -------------
BrandID   | int
BrandName  | nvarchar(25)

> **Cars**

Column Name  | Data Type
------------- | -------------
CarID   | int
BrandID  | int
ColorID   | int
ModelYear  | nvarchar(25)
DailyPrice   | decimal(18,0)
Description  | nvarchar(25)
CarName  | nvarchar(25)

> **Colors**

Column Name  | Data Type
------------- | -------------
ColorID   | int
ColorName  | nvarchar(25)

> **Customers**

Column Name  | Data Type
------------- | -------------
ID   | int
UserID   | int
CompanyName  | nvarchar(50)

> **Rentals**

Column Name  | Data Type
------------- | -------------
ID   | int
CarID   | int
CustomerID  | int
RentDate   | datetime
ReturnDate  | datetime

> **Users**

Column Name  | Data Type
------------- | -------------
ID   | int
FirstName   | nvarchar(50)
LastName  | nvarchar(50)
Email   | nvarchar(50)
Password  | nvarchar(50)
