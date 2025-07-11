USE [hasDB]
GO
/****** Object:  Table [dbo].[AssignList]    Script Date: 7/3/2025 5:16:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssignList](
	[PID] [varchar](50) NOT NULL,
	[FullName] [varchar](max) NULL,
	[Name] [varchar](max) NULL,
	[Specialty] [varchar](max) NULL,
	[APPTime] [datetime] NULL,
 CONSTRAINT [PK_AssignList] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 7/3/2025 5:16:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[DoctorID] [varchar](50) NOT NULL,
	[FullName] [varchar](max) NULL,
	[Specialty] [varchar](max) NULL,
	[Email] [varchar](max) NULL,
	[Phone] [varchar](max) NULL,
	[AvailabilityStatus] [varchar](max) NULL,
	[AvailableTime] [datetime] NULL,
 CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 7/3/2025 5:16:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[PID] [varchar](50) NOT NULL,
	[Name] [varchar](max) NULL,
	[BloodG] [nvarchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Age] [varchar](50) NULL,
	[Gender] [nchar](10) NULL,
	[Address] [varchar](max) NULL,
	[DOB] [datetime] NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-002', N'momo', N'Mahim', N'Cardiology', CAST(N'2025-07-03T02:43:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-003', N'dr. Nabil', N'Ayesha', N'Cardiology', CAST(N'2025-07-23T04:34:55.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-004', N'Dr. Sumi', N'Farhan', N'Orthopedics', CAST(N'2025-07-03T04:00:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-005', N'Dr. Zayed', N'Nira', N'Dermatology', CAST(N'2025-07-03T04:45:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-006', N'Dr. Mita', N'Imran', N'Pediatrics', CAST(N'2025-07-03T05:30:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-007', N'Dr. Rumi', N'Rafi', N'Cardiology', CAST(N'2025-07-03T06:10:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-008', N'Dr. Anik', N'Tania', N'Urology', CAST(N'2025-07-03T06:45:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-009', N'Dr. Lima', N'Kabir', N'ENT', CAST(N'2025-07-03T07:20:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-010', N'Dr. Hossain', N'Sonia', N'Neurology', CAST(N'2025-07-03T08:00:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-011', N'Dr. Ovi', N'Zahin', N'Oncology', CAST(N'2025-07-03T08:30:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-012', N'Dr. Tanvir', N'Shila', N'Gastroenterology', CAST(N'2025-07-03T09:00:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-013', N'Dr. Maliha', N'Noman', N'Psychiatry', CAST(N'2025-07-03T09:30:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-014', N'Dr. Kabir', N'Rumi', N'Nephrology', CAST(N'2025-07-03T10:00:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-015', N'Dr. Zinia', N'Arif', N'Endocrinology', CAST(N'2025-07-03T10:30:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-016', N'Dr. Arefin', N'Lubna', N'Pulmonology', CAST(N'2025-07-03T11:00:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-017', N'Dr. Sohana', N'Salman', N'Cardiology', CAST(N'2025-07-03T11:30:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-018', N'Dr. Meher', N'Tareq', N'Neurology', CAST(N'2025-07-03T12:00:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-019', N'Dr. Firoz', N'Ishrat', N'Hematology', CAST(N'2025-07-03T12:30:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-020', N'Dr. Iqbal', N'Hasan', N'Oncology', CAST(N'2025-07-03T13:00:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-021', N'Dr. Mim', N'Joya', N'Dermatology', CAST(N'2025-07-03T13:30:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-022', N'Dr. Zaman', N'Nadia', N'Gynecology', CAST(N'2025-07-03T14:00:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-023', N'Dr. Rafid', N'Mamun', N'Ophthalmology', CAST(N'2025-07-03T14:30:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-024', N'Dr. Sadiya', N'Ruba', N'Psychiatry', CAST(N'2025-07-03T15:00:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-025', N'Dr. Hamid', N'Shuvo', N'Cardiology', CAST(N'2025-07-03T15:30:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-026', N'Dr. Elita', N'Raisa', N'Neurology', CAST(N'2025-07-03T16:00:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-027', N'Dr. Fahim', N'Jihan', N'Urology', CAST(N'2025-07-03T16:30:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-028', N'Dr. Keya', N'Lamia', N'Endocrinology', CAST(N'2025-07-03T17:00:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-029', N'Dr. Munim', N'Rasel', N'Orthopedics', CAST(N'2025-07-03T17:30:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-030', N'Dr. Tamanna', N'Sneha', N'Pediatrics', CAST(N'2025-07-03T18:00:00.000' AS DateTime))
INSERT [dbo].[AssignList] ([PID], [FullName], [Name], [Specialty], [APPTime]) VALUES (N'P-031', N'Dr. Tarek', N'Raihan', N'Gastroenterology', CAST(N'2025-07-03T18:30:00.000' AS DateTime))
GO
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-001', N'Mahim', N'Cardiologist', N'mahim@hospital.com', N'01629942052', N'Available', CAST(N'2025-07-01T22:30:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-002', N'Dr. Ayesha Khan', N'Neurologist', N'ayesha@hospital.com', N'01711223344', N'Available', CAST(N'2025-07-02T09:00:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-003', N'Dr. Farhan Ali', N'Orthopedic', N'farhan@hospital.com', N'01882233445', N'Busy', CAST(N'2025-07-03T11:30:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-004', N'Dr. Nadia Hasan', N'Pediatrician', N'nadia@hospital.com', N'01553445566', N'Available', CAST(N'2025-07-02T15:00:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-005', N'Dr. Imran Hossain', N'Dermatologist', N'imran@hospital.com', N'01399887766', N'Unavailable', CAST(N'2025-07-04T14:00:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-006', N'Dr. Rifat Karim', N'Gynecologist', N'rifat@hospital.com', N'01755667788', N'Available', CAST(N'2025-07-05T10:30:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-007', N'Dr. Tanvir Ahmed', N'Psychiatrist', N'tanvir@hospital.com', N'01999887711', N'Available', CAST(N'2025-07-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-008', N'Dr. Nusrat Jahan', N'ENT Specialist', N'nusrat@hospital.com', N'01444556677', N'Available', CAST(N'2025-07-02T17:30:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-009', N'Dr. Rezaul Karim', N'Urologist', N'rezaul@hospital.com', N'01688776655', N'Unavailable', CAST(N'2025-07-07T08:45:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-010', N'Dr. Shila Rani', N'Oncologist', N'shila@hospital.com', N'01722334455', N'Available', CAST(N'2025-07-03T12:00:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-011', N'Dr. Arif Hossain', N'Radiologist', N'arif@hospital.com', N'01744556677', N'Available', CAST(N'2025-07-03T16:00:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-012', N'Dr. Lima Sultana', N'Anesthesiologist', N'lima@hospital.com', N'01886655443', N'Unavailable', CAST(N'2025-07-05T08:00:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-013', N'Dr. Jubayer Alam', N'Endocrinologist', N'jubayer@hospital.com', N'01644335522', N'Busy', CAST(N'2025-07-06T09:30:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-014', N'Dr. Sohana Rahman', N'Nephrologist', N'sohana@hospital.com', N'01562233444', N'Available', CAST(N'2025-07-08T10:45:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-015', N'Dr. Kazi Rahat', N'Pulmonologist', N'rahat@hospital.com', N'01377665588', N'Unavailable', CAST(N'2025-07-04T13:15:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-016', N'Dr. Noor Jahan', N'Hematologist', N'noor@hospital.com', N'01712345678', N'Available', CAST(N'2025-07-02T11:00:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-017', N'Dr. Asif Mahmud', N'Gastroenterologist', N'asif@hospital.com', N'01687654321', N'Busy', CAST(N'2025-07-07T14:30:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-018', N'Dr. Sumaiya Haque', N'General Surgeon', N'sumaiya@hospital.com', N'01555555666', N'Available', CAST(N'2025-07-03T18:45:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-019', N'Dr. Mehedi Hasan', N'Internal Medicine', N'mehedi@hospital.com', N'01987651234', N'Unavailable', CAST(N'2025-07-05T07:30:00.000' AS DateTime))
INSERT [dbo].[Doctors] ([DoctorID], [FullName], [Specialty], [Email], [Phone], [AvailabilityStatus], [AvailableTime]) VALUES (N'D-020', N'Dr. Tania Akter', N'Ophthalmologist', N'tania@hospital.com', N'01812349876', N'Available', CAST(N'2025-07-08T12:15:00.000' AS DateTime))
GO
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-001', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-002', N'Mahim', N'A+', N'01712345678', N'25', N'Male      ', N'Dhaka', CAST(N'2000-05-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-003', N'Ayesha', N'O+', N'01798765432', N'22', N'Female    ', N'Chittagong', CAST(N'2003-01-19T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-004', N'Farhan', N'B-', N'01812349876', N'30', N'Male      ', N'Sylhet', CAST(N'1995-08-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-005', N'Nira', N'AB+', N'01687654321', N'27', N'Female    ', N'Rajshahi', CAST(N'1998-03-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-006', N'Imran', N'A-', N'01945678901', N'35', N'Male      ', N'Barisal', CAST(N'1990-11-23T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-007', N'Rafi', N'O-', N'01734567891', N'29', N'Male      ', N'Rangpur', CAST(N'1996-06-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-008', N'Tania', N'B+', N'01898712345', N'24', N'Female    ', N'Khulna', CAST(N'2001-09-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-009', N'Kabir', N'AB-', N'01511122334', N'40', N'Male      ', N'Mymensingh', CAST(N'1985-12-30T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-010', N'Sonia', N'A+', N'01722998877', N'31', N'Female    ', N'Narayanganj', CAST(N'1994-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-011', N'Zahin', N'O+', N'01988776655', N'28', N'Male      ', N'Comilla', CAST(N'1997-04-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-012', N'Shila', N'B-', N'01744668899', N'26', N'Female    ', N'Gazipur', CAST(N'1999-07-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-013', N'Noman', N'A-', N'01833445566', N'33', N'Male      ', N'Cox’s Bazar', CAST(N'1992-10-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-014', N'Rumi', N'AB+', N'01655443322', N'36', N'Female    ', N'Pabna', CAST(N'1989-01-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-015', N'Arif', N'O-', N'01766554433', N'38', N'Male      ', N'Jessore', CAST(N'1987-08-16T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-016', N'Lubna', N'A+', N'01999887766', N'21', N'Female    ', N'Bogura', CAST(N'2004-05-03T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-017', N'Salman', N'B+', N'01778990011', N'23', N'Male      ', N'Noakhali', CAST(N'2002-11-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-018', N'Tareq', N'O+', N'01855667788', N'45', N'Male      ', N'Tangail', CAST(N'1980-06-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-019', N'Ishrat', N'A-', N'01911223344', N'34', N'Female    ', N'Kushtia', CAST(N'1991-03-27T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-020', N'Hasan', N'B-', N'01677889900', N'32', N'Male      ', N'Dinajpur', CAST(N'1993-10-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-021', N'Joya', N'AB-', N'01733442211', N'29', N'Female    ', N'Feni', CAST(N'1996-12-02T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-022', N'Nadia', N'A+', N'01711223344', N'26', N'Female    ', N'Dhaka', CAST(N'1999-09-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-023', N'Mamun', N'O-', N'01811223344', N'37', N'Male      ', N'Chandpur', CAST(N'1988-04-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-024', N'Ruba', N'B+', N'01911223344', N'28', N'Female    ', N'Kurigram', CAST(N'1997-01-30T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-025', N'Shuvo', N'AB-', N'01611223344', N'31', N'Male      ', N'Madaripur', CAST(N'1994-07-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-026', N'Raisa', N'A-', N'01511223344', N'24', N'Female    ', N'Manikganj', CAST(N'2001-11-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-027', N'Jihan', N'O+', N'01722334455', N'29', N'Male      ', N'Brahmanbaria', CAST(N'1996-03-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-028', N'Lamia', N'B-', N'01822334455', N'27', N'Female    ', N'Meherpur', CAST(N'1998-10-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-029', N'Rasel', N'AB+', N'01922334455', N'33', N'Male      ', N'Shariatpur', CAST(N'1992-06-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-030', N'Sneha', N'O+', N'01622334455', N'22', N'Female    ', N'Chapai Nawabganj', CAST(N'2003-12-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Patients] ([PID], [Name], [BloodG], [Phone], [Age], [Gender], [Address], [DOB]) VALUES (N'P-031', N'Raihan', N'A+', N'01522334455', N'36', N'Male      ', N'Jhenaidah', CAST(N'1989-05-06T00:00:00.000' AS DateTime))
GO
ALTER TABLE [dbo].[AssignList]  WITH CHECK ADD  CONSTRAINT [FK_AssignList_AssignList] FOREIGN KEY([PID])
REFERENCES [dbo].[AssignList] ([PID])
GO
ALTER TABLE [dbo].[AssignList] CHECK CONSTRAINT [FK_AssignList_AssignList]
GO
