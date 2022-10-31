CREATE DATABASE ITCA08
GO

USE ITCA08
GO

CREATE TABLE Productos(
id_producto varchar(5) constraint pk_id_producto primary key,
nombre varchar(20),
precio smallmoney
)

go
insert into Productos values ('001','pan','1')
insert into Productos values ('002','cafe','2')
insert into Productos values ('003','dona','2')
insert into Productos values ('004','semita','3')