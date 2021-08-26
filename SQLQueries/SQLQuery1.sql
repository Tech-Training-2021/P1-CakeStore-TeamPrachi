drop table Customer;

create table Customer(
	CustomerID int identity(1,1) primary key,
	CustomerName varchar(100) not null,
	ContactNo varchar(10),
	Pincode int
);

create table FlavourType(
	FlavourTypeID int identity(1,1) primary key,
	FlavourID int Foreign key references Flavour(FlavourID),
	FlavourTypeName varchar(100) not null,
	Price int,
	AvailableQuantity int
);

create table Flavour(
	FlavourID int identity(1,1) primary key,
	FlavourName varchar(100) not null
);

--create table Menu(
--	MenuID int identity(1,1) primary key,
--	FlavourID int Foreign key references Flavour(FlavourID)
--);

create table CakeOrder(
	OrderID int identity(1,1) primary key,
	FlavourTypeID int Foreign key references FlavourType(FlavourTypeID),
	OrderedQuantity int,
	TotalPrice int
);

create table OrderDetails(
	OrderDetailsID int identity(1,1) primary key,
	FlavourTypeID int Foreign key references FlavourType(FlavourTypeID),
	OrderedQuantity int,
	TotalPrice int
);

create table OrderHistory(
	CustomerID int Foreign key references Customer(CustomerID),
	OrderDetailsID int Foreign key references OrderDetails(OrderDetailsID)
);

Insert into Customer(CustomerName,ContactNo,Pincode) values ('Prachi',6542657654,421301);
Insert into Customer(CustomerName,ContactNo,Pincode) values ('Mayuri',9654321897,320111);
Insert into Customer(CustomerName,ContactNo,Pincode) values ('Krunal',8765432198,421302);
Insert into Customer(CustomerName,ContactNo,Pincode) values ('Jaideep',8765432198,421303);
Insert into Customer(CustomerName,ContactNo,Pincode) values ('Pranali',8123451678,421304);

select * from Customer;

alter table Customer
alter column CustomerID int primary key;

Delete from Customer where CustomerID=1;

Insert into FlavourType values (1,'Chocolate Espresso Layer Cake',500,10);
Insert into FlavourType values (1,'Double Chocolate Cake with Raspberry Buttercream',550,8);
Insert into FlavourType values (1,'Pecan-Studded Chocolate Sheet Cake',600,15);
Insert into FlavourType values (1,'Chocolate Stout Cake',700,12);
Insert into FlavourType values (1,'Chocolate Coffee Cake',500,8);

select * from FlavourType;

Insert into Flavour(FlavourName) values ('Chocolate');
Insert into Flavour(FlavourName) values ('Vanilla');
Insert into Flavour(FlavourName) values ('Strawberry');
Insert into Flavour(FlavourName) values ('Pinapple');
Insert into Flavour(FlavourName) values ('Rasmalai');
select * from Flavour;

Insert into CakeOrder values (3,4,2400);
select * from CakeOrder;

Insert into OrderDetails values (3,4,2400);
select * from OrderDetails;

Insert into OrderHistory values (1,1);
select * from OrderHistory;

drop table Menu;

