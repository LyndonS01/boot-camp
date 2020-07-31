-- data definition language

use master;
go

drop database PizzaStoreDb;
go
-- CREATE

create database PizzaStoreDb; --project
go

use PizzaStoreDb;
go

--drop schema Pizza;
--go

create schema Pizza; --namespace
go

--constraints = datatype, key, default, check, null, computed
--number datatypes = tinyint (int8), smallint (int16), int (int32), bigint (int64), numeric, decimal, money
--text datatypes = text, ntext, varchar (ascii), nvarchar (utf-8), char (ascii), nchar(utf-8)
--datetime datatypes = date, time, datetime, datetime2
--boolean datatypes = bit

create table Pizza.Pizza
(
  PizzaId int not null identity(1,1),
  CrustId int null,
  SizeId int null,
  OrderId int null,
  PizzaName nvarchar(250) not null,
  Qty int not null default 1,
  PizzaPrice decimal(8,2) not null,
  DateModified datetime2(0) not null default getdate(),
  Active bit not null default 1,
  constraint PK_Pizza_Pizza primary key clustered (PizzaId)
);

create table Pizza.Crust
(
  CrustId int not null identity(1,1),
  CrustName nvarchar(100) not null,
--  CrustPrice decimal(8,2) not null,
  DateModified datetime2(0) not null default getdate(),
  Active bit not null default 1,
  constraint PK_Pizza_Crust primary key clustered (CrustId)
);

create table Pizza.Size
(
  SizeId int not null identity(1,1),
  SizeName nvarchar(100) not null,
--  SizePrice decimal(8,2) not null,
  DateModified datetime2(0) not null default getdate(),
  Active bit not null default 1,
  constraint PK_Pizza_Size primary key clustered (SizeId)
);

create table Pizza.Topping
(
  ToppingId int not null identity(1,1),
  ToppingName nvarchar(100) not null,
--  ToppingPrice decimal(8,2) not null,
  DateModified datetime2(0) not null default getdate(),
  Active bit not null default 1,
  constraint PK_Pizza_Topping primary key clustered (ToppingId)
);

create table Pizza.PizzaTopping
(
--  PizzaToppingId int not null,
  PizzaId int not null,
  ToppingId int not null identity(1,1),
  DateModified datetime2(0) not null default getdate(),
  Active bit not null default 1
--  constraint PK_Pizza_PizzaTopping primary key clustered (PizzaToppingId)
);

alter table Pizza.Pizza
  add constraint FK_Pizza_CrustId foreign key (CrustId) references Pizza.Crust (CrustId);

alter table Pizza.Pizza
  add constraint FK_Pizza_SizeId foreign key (SizeId) references Pizza.Size (SizeId);

alter table Pizza.PizzaTopping
  add constraint PK_Pizza_PizzaTopping_PizzaId primary key clustered (PizzaId, ToppingId);  

alter table Pizza.PizzaTopping
  add constraint FK_Pizza_PizzaTopping_PizzaId foreign key (PizzaId) references Pizza.Pizza(PizzaId);

alter table Pizza.PizzaTopping
  add constraint FK_Pizza_PizzaTopping_ToppingId foreign key (ToppingId) references Pizza.Topping(ToppingId);

-- create orders, stores an users tables

create table Pizza.Orders
(
  OrderId int not null identity(1,1),  
  StoreId int not null,
  UserId int not null,
  OrderDate datetime2(0) not null default getdate(),
  PizzaId int not null,
--  Qty int not null default 1,
  Active bit not null default 1,
  constraint PK_Pizza_Orders primary key clustered (OrderId)
);


create table Pizza.Users
(
  UserId int not null identity(1,1),
  UserName nvarchar(50) not null,
  LastOrderDate datetime2(0) not null default getdate(),
  Active bit not null default 1,
  constraint PK_Pizza_Users primary key clustered (UserId)
);

create table Pizza.Stores
(
  StoreId int not null identity(1,1),
  StoreName nvarchar(50) not null,
  DateModified datetime2(0) not null default getdate(),
  Active bit not null default 1,
  constraint PK_Pizza_Stores primary key clustered (StoreId)
);

alter table Pizza.Orders
  add constraint FK_Pizza_PizzaOrders_StoreId foreign key (StoreId) references Pizza.Stores (StoreId);

alter table Pizza.Orders
  add constraint FK_Pizza_PizzaOrders_UserId foreign key (UserId) references Pizza.Users (UserId); 

alter table Pizza.Pizza
  add constraint FK_Pizza_OrderId foreign key (OrderId) references Pizza.Orders (OrderId);  

-- populate tables

  -- users

insert into pizza.users (username)
values
('lyndons'),
('johnd');


  -- stores
  
insert into pizza.stores (storename)
values
('Location A'),
('Location B'),
('Location C')

select 'PizzaStoreDB build done!'

GO

  -- size
  
insert into pizza.size (sizename)
values
('Regular'),
('Large'),
('Family')

  -- crust
  
insert into pizza.crust (crustname)
values
('Thin'),
('Thick'),
('Stuffed')

  -- topping
  
insert into pizza.topping (toppingname)
values
('cheese'),
('extra cheese'),
('pepperoni'),
('sausage'),
('bell peppers'),
('ham'),
('pineapple'),
('bacon'),
('mushrooms')

GO


