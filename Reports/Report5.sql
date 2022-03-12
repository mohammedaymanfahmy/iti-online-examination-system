USE [Online_Examination_System]
GO

/****** Object:  StoredProcedure [dbo].[spGetByIdExamQuesWizChoices]    Script Date: 2/25/2022 10:22:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[spGetByIdExamQuesWizChoices] @examNo int
as
	select Q.Ques_No,Q.Ques_Desc ,qc.Choice_No , qc.Choice_Desc  from Exam_Ques EQ
	inner join Question Q on EQ.Ques_No = q.Ques_No and EQ.Exam_No = @examNo
	inner join Ques_Choices QC on Q.Ques_No = qc.Ques_No
GO

