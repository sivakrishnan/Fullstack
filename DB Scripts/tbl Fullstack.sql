-- drop table MASGender
-- select * from MASGender
create table MASGender
(
	PKMASGenderID int not null identity (1, 1) constraint PCK_MASGender_PKMASGenderID PRIMARY KEY,

	GenderName varchar(100) not null constraint UCK_MASGender_GenderName unique,

	[IsActive] bit NOT NULL constraint  DCK_MASGender_IsActive default(1),
	[IsDeleted] bit NOT NULL constraint  DCK_MASGender_IsDeleted default(0),
	[CreatedBy] int NULL,
	[CreatedDate] datetime  NOT NULL constraint DCK_MASGender_CreatedDate default(getdate()),
	[ModifiedBy] int NULL,
	[ModifiedDate] datetime NOT NULL constraint DCK_MASGender_ModifiedDate default(getdate()),
)

insert into MASGender(GenderName
, IsActive, IsDeleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)
select 'Male'
, 1, 0, 1, GETDATE(), 1, GETDATE()
union
select 'Female'
, 1, 0, 1, GETDATE(), 1, GETDATE()
union
select 'Gender-1'
, 1, 0, 1, GETDATE(), 1, GETDATE()
union
select 'Gender-2'
, 1, 0, 1, GETDATE(), 1, GETDATE()
union
select 'Gender-3'
, 1, 0, 1, GETDATE(), 1, GETDATE()


----------------------------------------------------------------------------------


-- drop table MASCourse
-- select * from MASCourse
create table MASCourse
(
	PKMASCourseID int not null identity (1, 1) constraint PCK_MASCourse_PKMASCourseID PRIMARY KEY,

	CourseName varchar(100) not null constraint UCK_MASCourse_CourseName unique,

	[IsActive] bit NOT NULL constraint  DCK_MASCourse_IsActive default(1),
	[IsDeleted] bit NOT NULL constraint  DCK_MASCourse_IsDeleted default(0),
	[CreatedBy] int NULL,
	[CreatedDate] datetime  NOT NULL constraint DCK_MASCourse_CreatedDate default(getdate()),
	[ModifiedBy] int NULL,
	[ModifiedDate] datetime NOT NULL constraint DCK_MASCourse_ModifiedDate default(getdate()),
)

insert into MASCourse(CourseName
, IsActive, IsDeleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)
select 'Java'
, 1, 0, 1, GETDATE(), 1, GETDATE()
union
select 'Python'
, 1, 0, 1, GETDATE(), 1, GETDATE()
union
select 'CSharp'
, 1, 0, 1, GETDATE(), 1, GETDATE()
union
select 'Node JS'
, 1, 0, 1, GETDATE(), 1, GETDATE()
union
select 'Google Go'
, 1, 0, 1, GETDATE(), 1, GETDATE()


----------------------------------------------------------------------------------


-- drop table MASEmployee
-- select * from MASEmployee
create table MASEmployee
(
	PKMASEmployeeID int not null identity (1, 1) constraint PCK_MASEmployee_PKMASEmployeeID PRIMARY KEY,

	EmployeeID varchar(100) not null constraint UCK_MASEmployee_EmployeeID unique,
	EmployeeName varchar(1000) not null,
	Email varchar(1000) not null constraint UCK_MASEmployee_Email unique,

	FKMASGenderID int not null  constraint FCK_MASEmployee_FKMASGenderID_MASGender_PKMASGenderID
	references MASGender(PKMASGenderID),

	DateOfBirth date not null,

	[IsActive] bit NOT NULL constraint  DCK_MASEmployee_IsActive default(1),
	[IsDeleted] bit NOT NULL constraint  DCK_MASEmployee_IsDeleted default(0),
	[CreatedBy] int NULL,
	[CreatedDate] datetime  NOT NULL constraint DCK_MASEmployee_CreatedDate default(getdate()),
	[ModifiedBy] int NULL,
	[ModifiedDate] datetime NOT NULL constraint DCK_MASEmployee_ModifiedDate default(getdate()),
)

insert into MASEmployee(EmployeeID, EmployeeName, Email, FKMASGenderID, DateOfBirth
, IsActive, IsDeleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)
select 'Emp001', 'Emp001-EmployeeName', 'Emp001@mailinator.com', 5, '1991-1-1'
, 1, 0, 1, GETDATE(), 1, GETDATE()
union
select 'Emp002', 'Emp002-EmployeeName', 'Emp002@mailinator.com', 4, '1992-03-2'
, 1, 0, 1, GETDATE(), 1, GETDATE()
union
select 'Emp003', 'Emp003-EmployeeName', 'Emp003@mailinator.com', 3, '1993-04-3'
, 1, 0, 1, GETDATE(), 1, GETDATE()
union
select 'Emp004', 'Emp004-EmployeeName', 'Emp004@mailinator.com', 2, '1994-05-4'
, 1, 0, 1, GETDATE(), 1, GETDATE()



----------------------------------------------------------------------------------


-- drop table MAPEmployeeCourse
-- select * from MAPEmployeeCourse
--select * from MASEmployee
--select * from MASCourse
create table MAPEmployeeCourse
(
	PKMAPEmployeeCourseID int not null identity (1, 1) constraint PCK_MAPEmployeeCourse_PKMAPEmployeeCourseID PRIMARY KEY,	

	FKMASEmployeeID int not null  constraint FCK_MAPEmployeeCourse_FKMASEmployeeID_MASEmployee_PKMASEmployeeID
	references MASEmployee(PKMASEmployeeID),

	FKMASCourseID int not null  constraint FCK_MAPEmployeeCourse_FKMASCourseID_MASCourse_PKMASCourseID
	references MASCourse(PKMASCourseID),

	[IsActive] bit NOT NULL constraint  DCK_MAPEmployeeCourse_IsActive default(1),
	[IsDeleted] bit NOT NULL constraint  DCK_MAPEmployeeCourse_IsDeleted default(0),
	[CreatedBy] int NULL,
	[CreatedDate] datetime  NOT NULL constraint DCK_MAPEmployeeCourse_CreatedDate default(getdate()),
	[ModifiedBy] int NULL,
	[ModifiedDate] datetime NOT NULL constraint DCK_MAPEmployeeCourse_ModifiedDate default(getdate()),
)

--ALTER TABLE MAPEmployeeCourse
--ADD CONSTRAINT CPK_MAPEmployeeCourse_PKMAPEmployeeCourseID_FKMASEmployeeID_FKMASCourseID
--PRIMARY KEY (PKMAPEmployeeCourseID, FKMASEmployeeID, FKMASCourseID);

insert into MAPEmployeeCourse(FKMASEmployeeID, FKMASCourseID
, IsActive, IsDeleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate)
select 1, 1
, 1, 0, 1, GETDATE(), 1, GETDATE()
union
select 1, 2
, 1, 0, 1, GETDATE(), 1, GETDATE()
union
select 2, 1
, 1, 0, 1, GETDATE(), 1, GETDATE()
union
select 2, 4
, 1, 0, 1, GETDATE(), 1, GETDATE()
