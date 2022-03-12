USE [Online_Examination_System]
GO

/****** Object:  StoredProcedure [dbo].[spGetInstCrsInfo]    Script Date: 2/25/2022 10:21:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[spGetInstCrsInfo] @Inst_ID int
as
    BEGIN TRY 
		select  i.Ins_Name,c.Crs_Name, count(stc.St_Id) "Number of Strudents"
		from Instructor i inner join Ins_Course ic
		on i.Ins_Id=ic.Ins_Id and i.Ins_Id=@Inst_ID
		inner join Course c
		on c.Crs_Id=ic.Crs_Id
		inner join Stud_Course stc
		on stc.Crs_Id=c.Crs_Id
		group by i.Ins_Name,c.Crs_Name
		return 100
	END TRY
	BEGIN CATCH  
	   return 4000 
	END CATCH 

GO

