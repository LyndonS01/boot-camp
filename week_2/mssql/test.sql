drop DATABASE TestDb;

create database TestDb;
GO

create schema Testing;
go

drop table Testing.CompositePKTable;
GO

CREATE TABLE Testing.CompositePKTable
(
  column1 INT NOT NULL,
  column2 INT NOT NULL,
  column3 VARCHAR(50)

  CONSTRAINT PK_CompositePKTable PRIMARY KEY CLUSTERED (column1, column2)
  -- CONSTRAINT PK_CompositePKTable PRIMARY KEY NONCLUSTERED (column1, column2)
)

insert into Testing.CompositePKTABLE
  (column1, column2, column3)
VALUES
  (1, 1, 'test1'),
  (1, 2, 'test2'),
  (2, 1, 'test3'),
  (2, 2, 'test4');

SELECT * from Testing.CompositePKTable;

SELECT * from Testing.CompositePKTable
where column1 = 2;

delete from Testing.CompositePKTABLE
where column2 = 2;

use master;

drop database PizzaStoreDb;





