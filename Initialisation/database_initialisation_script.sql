-- 1. Connect to your SQL Server instance, master database

-- 2. Run the following code to create an empty database called XYZCarSales
USE master;

-- Drop database
IF DB_ID('XYZCarSales') IS NOT NULL DROP DATABASE XYZCarSales;

-- If database could not be created due to open connections, abort
IF @@ERROR = 3702 
   RAISERROR('Database cannot be dropped because there are still open connections.', 127, 127) WITH NOWAIT, LOG;

GO

-- Create database
CREATE DATABASE XYZCarSales;
GO

USE XYZCarSales;
GO

---------------------------------------------------------------------
-- Create Tables
---------------------------------------------------------------------

-- Create table Cars
CREATE TABLE Cars
(
	Id               INT            NOT NULL IDENTITY(1,1),
	VIN              VARCHAR(100)   NOT NULL,
	Manufacturer     VARCHAR(100)   NOT NULL,
	ManufacturedYear INT            NOT NULL,
	Price            NUMERIC(10, 0) NOT NULL,
	Model            VARCHAR(100)   NOT NULL,
	ImagePath        VARCHAR(MAX)   NULL,
	CONSTRAINT PK_Cars PRIMARY KEY(Id),
	CONSTRAINT UK_VIN UNIQUE(VIN),
	CONSTRAINT CHK_ManufacturedYear CHECK(ManufacturedYear >= 1990 AND ManufacturedYear <= YEAR(GETDATE())),
	CONSTRAINT CHK_Price CHECK(Price > 0)
);

-- Create table UsedCars
CREATE TABLE UsedCars
(
	Id               INT             NOT NULL,
	DistanceCovered  NUMERIC (10, 2) NOT NULL,
	CONSTRAINT PK_UsedCars PRIMARY KEY (Id, DistanceCovered),
	CONSTRAINT FK_UsedCars_Cars FOREIGN KEY(Id) REFERENCES Cars(Id)
);

-- Create table Customers
CREATE TABLE Customers
(
	Id               INT           NOT NULL IDENTITY(1,1),
	[Name]           VARCHAR(100)  NOT NULL,
	Email            VARCHAR(100)  NULL,
	PhoneNumber      VARCHAR(100)  NOT NULL,
	CONSTRAINT PK_Customers PRIMARY KEY(Id),
	CONSTRAINT CHK_Email CHECK(Email LIKE '%@%'),
	CONSTRAINT UK_Email UNIQUE (Email),
	CONSTRAINT UK_PhoneNumber UNIQUE (PhoneNumber),
);

-- Create table Employees
CREATE TABLE Employees
(
	Id               INT            NOT NULL IDENTITY(1,1),
	[Name]           VARCHAR(100)   NOT NULL,
	Username         VARCHAR(100)   NOT NULL,
	[Password]       VARBINARY(MAX) NOT NULL,
	CONSTRAINT UK_Username  UNIQUE (Username),
	CONSTRAINT PK_Employees PRIMARY KEY(Id),
);

-- Create table Sales
CREATE TABLE Sales
(
    Id               INT           NOT NULL IDENTITY(1,1),
	CarId            INT           NOT NULL,
	CustomerId       INT           NOT NULL,
	EmployeeId       INT           NOT NULL,
	PurchaseDate     DATETIME      NOT NULL,
	CONSTRAINT PK_Sales PRIMARY KEY(Id),
	CONSTRAINT UK_Sales UNIQUE(CarId),
	CONSTRAINT FK_Sales_Cars FOREIGN KEY(CarId) REFERENCES Cars(Id),
	CONSTRAINT FK_Sales_Customers FOREIGN KEY(CustomerId) REFERENCES Customers(Id),
	CONSTRAINT FK_Sales_Employees FOREIGN KEY(EmployeeId) REFERENCES Employees(Id),
);

---------------------------------------------------------------------
-- Populate Tables
---------------------------------------------------------------------

SET NOCOUNT ON;

-- Populate table Cars
SET IDENTITY_INSERT Cars ON;
INSERT INTO Cars(Id, VIN, Manufacturer, ManufacturedYear, Price, Model, ImagePath)
VALUES (1, '1111111111', 'Mercedes', 2020, 100000, 'Model-mercedes-1', '..\..\..\..\..\Car images\dillon-kydd-SHXCj2Syo7c-unsplash.jpg')
      ,(2, '2222222222', 'BMW', 2022, 150000, 'Model-BMW-1', '..\..\..\..\..\Car images\grahame-jenkins-p7tai9P7H-s-unsplash.jpg')
	  ,(3, '3333333333', 'Ford', 2022, 120000, 'Model-Ford-1', '..\..\..\..\..\Car images\joshua-koblin-eqW1MPinEV4-unsplash.jpg')
	  ,(4, '4444444444', 'Nissan', 2019, 90000, 'Model-Nissan-1', '..\..\..\..\..\Car images\lance-asper-N9Pf2J656aQ-unsplash.jpg')
	  ,(5, '5555555555', 'Honda', 2020, 100000, 'Model-Honda-1', '..\..\..\..\..\Car images\marek-pospisil-oUBjd22gF6w-unsplash.jpg')
	  ,(6, '6666666666', 'Mercedes', 2022, 170000, 'Model-Mercedes-2', '..\..\..\..\..\Car images\olav-tvedt-6lSBynPRaAQ-unsplash.jpg')
	  ,(7, '7777777777', 'BMW', 2022, 180000, 'Model-BMW-2', '..\..\..\..\..\Car images\peter-broomfield-m3m-lnR90uM-unsplash.jpg')
	  ,(8, '8888888888', 'Nissan', 2022, 120000, 'Model-Nissan-2', '..\..\..\..\..\Car images\stefan-rodriguez-2AovfzYV3rc-unsplash.jpg')
	  ,(9, '9999999999', 'BMW', 2023, 200000, 'Model-BMW-3', '..\..\..\..\..\Car images\steven-binotto-o6yH_yAc2Ws-unsplash.jpg')
	  ,(10, '10101010101010101010', 'Nissan', 2000, 70000, 'Model-Nissan-3', NULL)
SET IDENTITY_INSERT Cars OFF;

-- Populate table UsedCars
INSERT INTO UsedCars(Id, DistanceCovered)
VALUES (10, 360000)
      ,(6, 50000)
	  ,(1, 6000)

-- Populate table Customers
SET IDENTITY_INSERT Customers ON;
INSERT INTO Customers(Id, [Name], Email, PhoneNumber)
VALUES (1, 'Steven Gerrard', 'stev_ger@gmail.com', '+44 7975444230')
      ,(2, 'Micheal Owen', 'mic_owen@gmail.com', '+44 7459444452')
	  ,(3, 'Jimmy Carrager', 'jimmy_carrager@gmail.com', '+44 7459412456')
SET IDENTITY_INSERT Customers OFF;

-- Populate table Employees
SET IDENTITY_INSERT Employees ON;
INSERT INTO Employees (Id, [Name], Username, [Password])
VALUES (1, 'Tabrez Lallmahomed', 'tabrez', CONVERT(VARBINARY, HASHBYTES('MD5', 'employee1'))) -- password: employee1
      ,(2, 'Sadio Mane', 'sadio', CONVERT(VARBINARY, HASHBYTES('MD5', 'employee2'))) -- password: employee2
SET IDENTITY_INSERT Employees OFF;

-- Populate table Sales
SET IDENTITY_INSERT Sales ON;
INSERT INTO Sales (Id, CarId, CustomerId, EmployeeId, PurchaseDate)
VALUES (1, 1, 1, 1, cast('2021-12-31' as datetime))
      ,(2, 4, 2, 1, cast('2022-11-01' as datetime))
	  ,(3, 10, 3, 2, cast('2005-01-01' as datetime))
SET IDENTITY_INSERT Sales OFF;

GO
