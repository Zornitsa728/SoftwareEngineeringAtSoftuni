CREATE TABLE Passports 
(
PassportID INT PRIMARY KEY IDENTITY(101,1),
PassportNumber VARCHAR(100)
)

INSERT INTO Passports (PassportNumber)
VALUES ('N34FG21B'),
       ('K65LO4R7'),
	   ('ZE657QP2')

CREATE TABLE Persons 
(
PersonID INT PRIMARY KEY IDENTITY,
FirstName VARCHAR(60),
Salary DECIMAL(10,2),
PassportID INT UNIQUE,
CONSTRAINT FK_Passports_Persons
FOREIGN KEY (PassportID)
REFERENCES Passports(PassportID)
)


INSERT INTO Persons (FirstName, Salary, PassportID)
VALUES ('Roberto', 43300.00, 102),
       ('Tom', 56100.00, 103),
	   ('Yana', 60200.00, 101)


CREATE TABLE Manufacturers 
(
   ManufacturerID INT PRIMARY KEY IDENTITY, 
   [Name] VARCHAR(60) NOT NULL,
   EstablishedOn DATETIME2
)

INSERT INTO Manufacturers ([Name], EstablishedOn)
VALUES ('BMW', '07/03/1916'),
       ('Tesla', '01/01/2003'),
	   ('Lada', '01/05/1966')

CREATE TABLE Models 
(
   ModelID INT PRIMARY KEY IDENTITY(101,1),
   [Name] VARCHAR(100) NOT NULL,
   ManufacturerID INT,
   CONSTRAINT FC_MODELS_MANUFACTURER
   FOREIGN KEY (ManufacturerID)
   REFERENCES Manufacturers(ManufacturerID)
)

INSERT INTO Models ([Name], ManufacturerID)
VALUES ('X1', 1),
       ('i6', 1),
	   ('Model S', 2),
	   ('Model X', 2),
	   ('Model 3', 2),
	   ('Nova', 3)

CREATE TABLE Students 
(
   StudentID INT PRIMARY KEY IDENTITY,
   [Name] VARCHAR(100)
)

INSERT INTO Students ([Name])
VALUES ('Mila'),
       ('Toni'),
	   ('Ron')

CREATE TABLE Exams 
(
   ExamID INT PRIMARY KEY IDENTITY(101, 1),
   [Name] VARCHAR(100)
)

INSERT INTO Exams ([Name])
VALUES ('SpringMVC'),
       ('Neo4j'),
	   ('Oracle 11g')

CREATE TABLE StudentsExams 
(
    StudentID INT,
	ExamID INT,
	CONSTRAINT PK_StudentsExams
	PRIMARY KEY (StudentID, ExamID),
	CONSTRAINT FK_StudentsExams_Students
	FOREIGN KEY (StudentID)
	REFERENCES Students(StudentID),
	CONSTRAINT FK_StudentsExams_Exams
	FOREIGN KEY (ExamID)
	REFERENCES Exams(ExamID)
)

	INSERT INTO StudentsExams
	VALUES (1, 101),
	       (1, 102),
		   (2, 101),
		   (3, 103),
		   (2, 102),
		   (2, 103)

--04.

CREATE TABLE Teachers
(
   TeacherID INT PRIMARY KEY IDENTITY(101, 1),
   [Name] VARCHAR(100) NOT NULL,
   ManagerID INT,
   CONSTRAINT FC_Teachers 
   FOREIGN KEY (ManagerID)
   REFERENCES Teachers (TeacherID)
)
	
	INSERT INTO Teachers ([Name], ManagerID)
	VALUES ('John', NULL),
	       ('Maya', 106),
		   ('Silvia', 106),
		   ('Ted', 105),
		   ('Mark', 101),
		   ('Greta', 101)

--05.
CREATE DATABASE Items
GO

USE Items

CREATE TABLE ItemTypes 
(
    ItemTypeID INT PRIMARY KEY IDENTITY, 
	Name VARCHAR(100)
)

CREATE TABLE Items
(
    ItemID INT PRIMARY KEY IDENTITY, 
	Name VARCHAR(100),
	ItemTypeID INT,
	CONSTRAINT FC_Items_ItemTypes
	FOREIGN KEY (ItemTypeID)
	REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE Cities
(
    CityID INT PRIMARY KEY IDENTITY, 
	Name VARCHAR(100)
)

CREATE TABLE Customers
(
    CustomerID INT PRIMARY KEY IDENTITY, 
	Name VARCHAR(100),
	Birthday DATETIME2,
	CityID INT,
	CONSTRAINT FC_Customers_Cities
	FOREIGN KEY (CityID)
	REFERENCES Cities(CityID)
)

CREATE TABLE Orders
(
    OrderID INT PRIMARY KEY IDENTITY, 
	CustomerID INT,
	CONSTRAINT FC_Orders_Customers
	FOREIGN KEY (CustomerID)
	REFERENCES Customers(CustomerID)
)

CREATE TABLE OrderItems
(
    OrderID INT, 
	ItemID INT,
	CONSTRAINT PK_OrderItems
	PRIMARY KEY (OrderID, ItemID),
	CONSTRAINT FC_OrderItems_Orders
	FOREIGN KEY (OrderID)
	REFERENCES Orders(OrderID),
	CONSTRAINT FC_OrderItems_Items
	FOREIGN KEY (ItemID)
	REFERENCES Items(ItemID),
)

GO

CREATE DATABASE University
GO

USE University
GO

CREATE TABLE Majors
(
    mAJORID INT PRIMARY KEY IDENTITY, 
	Name VARCHAR(200)
)

CREATE TABLE Students
(
    StudentID INT PRIMARY KEY IDENTITY, 
	StudentNumber INT,
	StudentName VARCHAR(100),
	MajorID INT,
	CONSTRAINT FC_Students_Majors
	FOREIGN KEY (MajorID)
	REFERENCES Majors(MajorID)
)

CREATE TABLE Payments
(
    PaymentID INT PRIMARY KEY IDENTITY, 
	PaymentDate DATETIME2,
	PaymentAmount DECIMAL (10, 2),
	StudentID INT,
	CONSTRAINT FC_Payments_Students
	FOREIGN KEY (StudentID)
	REFERENCES Students(StudentID)
)

CREATE TABLE Subjects
(
    SubjectID INT PRIMARY KEY IDENTITY, 
	SubjectName VARCHAR(100)
)

CREATE TABLE Agenda
(
    StudentID INT , 
	SubjectID INT,
	CONSTRAINT PK_Agenda
	PRIMARY KEY (StudentID, SubjectID),
	CONSTRAINT FC_Agenda_Students
	FOREIGN KEY (StudentID)
	REFERENCES Students(StudentID),
	CONSTRAINT FC_Agenda_Subjects
	FOREIGN KEY (SubjectID)
	REFERENCES Subjects(SubjectID)
)

--09.
USE Geography

  SELECT m.MountainRange, p.PeakName, p.Elevation
    FROM Mountains AS m
    JOIN Peaks AS p ON p.MountainId = m.Id
   WHERE m.MountainRange = 'Rila'
ORDER BY p.Elevation DESC

