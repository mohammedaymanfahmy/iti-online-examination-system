USE [Online_Examination_System]
GO

/****** Object:  StoredProcedure [dbo].[showStudentData]    Script Date: 2/25/2022 10:23:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

  create proc [dbo].[showStudentData] @DeptId int 
as
	select * 
	from Student
	where Dept_Id = @DeptId
GO

