if not exists(select * from sys.databases where name = 'University')
create database [University]
GO

USE [University]
GO

-----------------------------

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'AdministratorLogin')
DROP TABLE [dbo].[AdministratorLogin]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Administrator')
DROP TABLE [dbo].[Administrator]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'InstructorLogin')
DROP TABLE [dbo].[InstructorLogin]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'StudentLogin')
DROP TABLE [dbo].[StudentLogin]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Student')
DROP TABLE [dbo].[Student]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Student_Status')
DROP TABLE [dbo].[Student_Status]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Degree')
DROP TABLE [dbo].[Degree]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Major')
DROP TABLE [dbo].[Major]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Minor')
DROP TABLE [dbo].[Minor]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Honors')
DROP TABLE [dbo].[Honors]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Department')
DROP TABLE [dbo].[Department]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Location')
DROP TABLE [dbo].[Location]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Location_Type')
DROP TABLE [dbo].[Location_Type]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Instructor')
DROP TABLE [dbo].[Instructor]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Faculty_Type')
DROP TABLE [dbo].[Faculty_Type]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Degree_Type')
DROP TABLE [dbo].[Degree_Type]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Grade')
DROP TABLE [dbo].[Grade]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Registration')
DROP TABLE [dbo].[Registration]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Section')
DROP TABLE [dbo].[Section]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Course')
DROP TABLE [dbo].[Course]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Semester')
DROP TABLE [dbo].[Semester]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Slot')
DROP TABLE [dbo].[Slot]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Day')
DROP TABLE [dbo].[Day]
GO

---------------------------------

SET ANSI_NULLS ON
GO

---------------------------------

CREATE TABLE [dbo].[Student_Status]
(
	[Status_ID] [int] NOT NULL IDENTITY (1,1),
	[Year_Status] [varchar] (9) NOT NULL,
	CONSTRAINT [PK_StudentStatus] PRIMARY KEY CLUSTERED ([Status_ID] ASC),
	CONSTRAINT [UK_StudentStatus] UNIQUE ([Year_Status])
)

CREATE TABLE [dbo].[Major]
(
	[Major_ID] [int] NOT NULL IDENTITY (1,1),
	[Major_Name] [varchar](20) NOT NULL,
	CONSTRAINT [PK_Major] PRIMARY KEY CLUSTERED ([Major_ID] ASC),
	CONSTRAINT [UK_Major] UNIQUE ([Major_Name])
)


CREATE TABLE [dbo].[Minor]
(
	[Minor_ID] [int] NOT NULL IDENTITY (1,1),
	[Minor_Name] [varchar](20) NOT NULL,
	CONSTRAINT [PK_Minor] PRIMARY KEY CLUSTERED ([Minor_ID] ASC),
	CONSTRAINT [UK_Minor] UNIQUE ([Minor_Name])
)


CREATE TABLE [dbo].[Honors]
(
	[Honors_ID] [int] NOT NULL IDENTITY (1,1),
	[Honors_Status] [int] NOT NULL,
	CONSTRAINT [PK_Honors] PRIMARY KEY CLUSTERED ([Honors_ID] ASC),
	CONSTRAINT [UK_Honors] UNIQUE ([Honors_Status])
)


CREATE TABLE [dbo].[Department]
(
	[Dept_ID] [int] NOT NULL IDENTITY (1,1),
	[Dept_Name] [varchar](20) NOT NULL,
	[Code] [varchar](5) NOT NULL,
	CONSTRAINT [PK_Dept] PRIMARY KEY CLUSTERED ([Dept_ID] ASC),
	CONSTRAINT [UK_Dept] UNIQUE ([Dept_Name], [Code])
)


CREATE TABLE [dbo].[Location_Type]
(
	[Location_Type_ID] [int] NOT NULL IDENTITY (1,1),
	[Loc_Type] [varchar](20) NOT NULL,
	CONSTRAINT [PK_Location_Type] PRIMARY KEY CLUSTERED ([Location_Type_ID] ASC),
	CONSTRAINT [UK_Location_Type] UNIQUE ([Loc_Type])
)

CREATE TABLE [dbo].[Faculty_Type]
(
	[Faculty_Type_ID] [int] NOT NULL IDENTITY (1,1),
	[Faculty_Type] [varchar](20) NOT NULL,
	CONSTRAINT [PK_Faculty_Type] PRIMARY KEY CLUSTERED ([Faculty_Type_ID] ASC),
	CONSTRAINT [UK_Faculty_Type] UNIQUE ([Faculty_Type])
)


CREATE TABLE [dbo].[Degree_Type]
(
	[Degree_Type_ID] [int] NOT NULL IDENTITY (1,1),
	[Degree_Title] [varchar](30) NOT NULL,
	CONSTRAINT [PK_Degree_Type] PRIMARY KEY CLUSTERED ([Degree_Type_ID] ASC),
	CONSTRAINT [UK_Degree_Type] UNIQUE ([Degree_Title])
)


CREATE TABLE [dbo].[Grade]
(
	[Grade_ID] [int] NOT NULL IDENTITY (1,1),	
	[Letter_Grade] [varchar](2) NOT NULL,
	CONSTRAINT [PK_Grade] PRIMARY KEY CLUSTERED ([Grade_ID] ASC),
	CONSTRAINT [UK_Grade] UNIQUE ([Letter_Grade])
)

CREATE TABLE [dbo].[Semester]
(
	[Semester_ID] [int] NOT NULL IDENTITY(1,1),
	[Season] [varchar](6) NOT NULL,
	[Year] [varchar](4) NOT NULL,
	CONSTRAINT [PK_Semester] PRIMARY KEY CLUSTERED ([Semester_ID] ASC),
	CONSTRAINT [UK_Semester] UNIQUE([Season], [Year])
)


CREATE TABLE [dbo].[Day]
(
	[Day_ID] [int] NOT NULL IDENTITY(1,1),
	[Day_Code] [varchar](4) NOT NULL,
	CONSTRAINT [PK_Day] PRIMARY KEY CLUSTERED ([Day_ID] ASC),
	CONSTRAINT [UK_Day] UNIQUE ([Day_Code])
)

------Tables with Foreign key references


CREATE TABLE [dbo].[Student]
(
	[Student_ID] [int] NOT NULL IDENTITY (1,1),
	[First_Name] [varchar](20) NOT NULL,
	[Middle_Name] [varchar](20),
	[Last_Name] [varchar](20) NOT NULL,
	[DOB] [date] NOT NULL,
	[Student_Email] [varchar](30),
	[Address] [varchar](50),
	[Phone_Number] [varchar](15),
	[Major_ID] [int],
	[Minor_ID] [int],
	[Honors_ID] [int] NOT NULL,
	[Status_ID] [int] NOT NULL,
	[Timestamp] DateTime,
	[Username] as concat(
		(
			lower(
					(LEFT(First_Name, 1)
					)
					)
					+ 
			lower(
					RTRIM
					(
					LEFT(Last_Name, 7)
					)
			)	
		)
		, Student_ID
		),
	CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Student_ID] ASC),
	CONSTRAINT [FK_Major] FOREIGN KEY (Major_ID) REFERENCES Major([Major_ID]),
	CONSTRAINT [FK_Minor] FOREIGN KEY (Minor_ID) REFERENCES Minor([Minor_ID]),
	CONSTRAINT [FK_Honors] FOREIGN KEY (Honors_ID) REFERENCES Honors([Honors_ID]),
	CONSTRAINT [FK_Status] FOREIGN KEY (Status_ID) REFERENCES Student_Status([Status_ID]),
	CONSTRAINT [UK_Student] UNIQUE ([First_Name], [Last_Name], [DOB])
)

CREATE TABLE [dbo].[Location]
(
	[Location_ID] [int] NOT NULL IDENTITY (1,1),
	[Room_Num] [varchar](10) NOT NULL,
	[Location_Type_ID] [int] NOT NULL,
	CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED ([Location_ID] ASC),
	CONSTRAINT [FK_Location_Type] FOREIGN KEY (Location_Type_ID) REFERENCES Location_Type([Location_Type_ID]),
	CONSTRAINT [UK_Location] UNIQUE ([Room_Num])
	--This is because we assumed we are dealing with one building
)

CREATE TABLE [dbo].[Instructor]
(
	[Instructor_ID] [int] NOT NULL IDENTITY (1,1),
	[Instructor_Title] [varchar](5) NOT NULL,
	[First_Name] [varchar](20) NOT NULL,
	[Middle_Name] [varchar](20),
	[Last_Name] [varchar](20) NOT NULL,
	[Instructor_Email] [varchar](30),
	[Address] [varchar](50),
	[Phone_Number] [varchar](15),
	[Dept_ID] [int] NOT NULL,
	[Faculty_Type_ID] [int] NOT NULL,
	[Username] as concat(
		(
			lower(
					(LEFT(First_Name, 1)
					)
					)
					+ 
			lower(
					RTRIM
					(
					LEFT(Last_Name, 7)
					)
			)	
		)
		, Instructor_ID
		),
	CONSTRAINT [PK_Instructor] PRIMARY KEY CLUSTERED ([Instructor_ID] ASC),
	CONSTRAINT [FK_Inst_Dept] FOREIGN KEY (Dept_ID) REFERENCES Department([Dept_ID]),
	CONSTRAINT [FK_Faculty_Type] FOREIGN KEY (Faculty_Type_ID) REFERENCES Faculty_Type([Faculty_Type_ID]),
	CONSTRAINT [UK_Instructor] UNIQUE ([First_Name], [Last_Name], [Dept_ID], [Faculty_Type_ID])
)

CREATE TABLE [dbo].[Administrator]
(
	[Admin_ID] [int] NOT NULL IDENTITY (1,1),
	[Admin_Title] [varchar](5) NOT NULL,
	[First_Name] [varchar](20) NOT NULL,
	[Middle_Name] [varchar](20),
	[Last_Name] [varchar](20) NOT NULL,
	[Admin_Email] [varchar](30),
	[Address] [varchar](50),
	[Phone_Number] [varchar](15),
	[Username] as concat(
		(
			lower(
					(LEFT(First_Name, 1)
					)
					)
					+ 
			lower(
					RTRIM
					(
					LEFT(Last_Name, 7)
					)
			)	
		)
		, Admin_ID
		),
	CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED ([Admin_ID] ASC),
	CONSTRAINT [UK_Admin] UNIQUE ([Admin_ID], [First_Name], [Last_Name])
)

CREATE TABLE [dbo].[Degree]
(
	[Instructor_ID] [int] NOT NULL,
	[Degree_Type_ID] [int] NOT NULL,
	CONSTRAINT [FK_Inst_Degree] FOREIGN KEY (Instructor_ID) REFERENCES Instructor([Instructor_ID]),
	CONSTRAINT [FK_Degree_Type] FOREIGN KEY (Degree_Type_ID) REFERENCES Degree_Type([Degree_Type_ID]),
	CONSTRAINT [UK_Degree] UNIQUE ([Instructor_ID], [Degree_Type_ID])
)

CREATE TABLE [dbo].[Course]
(
	[Course_ID] [int] NOT NULL IDENTITY(1,1),
	[Department] [int] NOT NULL,
	[Course_Number] [int] NOT NULL,
	[Course_Title] [varchar](30) NOT NULL,
	[PreReqs] [varchar](7),
	[CoReqs] [varchar](7),
	CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED ([Course_ID] ASC),
	CONSTRAINT [FK_Course_Dept] FOREIGN KEY (Department) REFERENCES Department([Dept_ID]),
	CONSTRAINT [UK_Course] UNIQUE ([Department], [Course_Number], [Course_Title])
)

CREATE TABLE [dbo].[Slot]
(
	[Slot_ID] [int] NOT NULL IDENTITY(1,1),
	[Day_ID] [int] NOT NULL,
	[Start_Time] [time] NOT NULL,
	[End_Time] [time] NOT NULL,
	CONSTRAINT [PK_Slot] PRIMARY KEY CLUSTERED ([Slot_ID] ASC),
	CONSTRAINT [FK_Day] FOREIGN KEY (Day_ID) REFERENCES [Day]([Day_ID]),
	CONSTRAINT [UK_Slot] UNIQUE ([Day_ID], [Start_Time], [End_Time])
)


CREATE TABLE [dbo].[Section]
(
	[Section_ID] [int] NOT NULL IDENTITY(1,1),
	[Registration_Limit] [int] NOT NULL,
	[Slot_ID] [int] NOT NULL,
	[Location_ID] [int] NOT NULL,
	[Instructor_ID] [int] NOT NULL,
	[Semester_ID] [int] NOT NULL,
	[Course_ID] [int] NOT NULL,
	CONSTRAINT [PK_Section] PRIMARY KEY CLUSTERED ([Section_ID] ASC),
	CONSTRAINT [FK_Slot] FOREIGN KEY (Slot_ID) REFERENCES Slot([Slot_ID]),
	CONSTRAINT [FK_Location] FOREIGN KEY (Location_ID) REFERENCES Location([Location_ID]), --Location as table name is a key word - why?
	CONSTRAINT [FK_Section_Inst] FOREIGN KEY (Instructor_ID) REFERENCES Instructor([Instructor_ID]),
	CONSTRAINT [FK_Semester] FOREIGN KEY (Semester_ID) REFERENCES Semester([Semester_ID]),
	CONSTRAINT [FK_Course] FOREIGN KEY (Course_ID) REFERENCES Course([Course_ID]),
	CONSTRAINT [UK_Section] UNIQUE ([Registration_Limit], [Slot_ID], [Location_ID], [Instructor_ID], [Semester_ID], [Course_ID])
)

CREATE TABLE [dbo].[Registration]
(
	[Section_ID] [int] NOT NULL,
	[Student_ID] [int] NOT NULL,
	[Grade_ID] [int] NOT NULL,
	CONSTRAINT [FK_Section] FOREIGN KEY (Section_ID) REFERENCES Section([Section_ID]),
	CONSTRAINT [FK_Student] FOREIGN KEY (Student_ID) REFERENCES Student([Student_ID]),
	CONSTRAINT [FK_Grade] FOREIGN KEY (Grade_ID) REFERENCES Grade([Grade_ID]),
	CONSTRAINT [UK_Registration] UNIQUE ([Section_ID], [Student_ID], [Grade_ID])
)

CREATE TABLE [dbo].[StudentLogin]
(
    StuUserID INT IDENTITY(1,1) NOT NULL,
	LoginID INT NOT NULL,
    [password] varchar(max) NOT NULL,
    CONSTRAINT [PK_Student_Login] PRIMARY KEY CLUSTERED (StuUserID ASC),
	CONSTRAINT [FK_Student_Username] FOREIGN KEY (LoginID) REFERENCES Student([Student_ID]),
	CONSTRAINT [UK_Student_Login] UNIQUE (StuUserID, LoginID)
)

CREATE TABLE [dbo].[InstructorLogin]
(
    InstUserID INT IDENTITY(1,1) NOT NULL,
	LoginID INT NOT NULL,
    [password] varchar(max) NOT NULL,
    CONSTRAINT [PK_Inst_Login] PRIMARY KEY CLUSTERED (InstUserID ASC),
	CONSTRAINT [FK_Inst_Username] FOREIGN KEY (LoginID) REFERENCES Instructor([Instructor_ID]),
	CONSTRAINT [UK_Inst_Login] UNIQUE (InstUserID, LoginID)
)

CREATE TABLE [dbo].[AdministratorLogin]
(
    AdminUserID INT IDENTITY(1,1) NOT NULL,
	LoginID INT NOT NULL,
    [password] varchar(max) NOT NULL,
    CONSTRAINT [PK_Admin_Login] PRIMARY KEY CLUSTERED (AdminUserID ASC),
	CONSTRAINT [FK_Admin_Username] FOREIGN KEY (LoginID) REFERENCES Administrator([Admin_ID]),
	CONSTRAINT [UK_Admin_Login] UNIQUE (AdminUserID, LoginID)
)

GO