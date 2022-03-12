using System;
using System.Collections.Generic;
using System.Linq;
using DAL;

using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class StudentManager
    {
        private static DBManager dBManager = new DBManager();

        public static Student spGetByIdStudent(int id , out bool flag)
        {
            Student student = new Student();
            try
            {
                Dictionary<string, object> parms = new Dictionary<string, object>();
                parms.Add("stId", id);
                DataTable DT = dBManager.ExecuteDataTable("spGetByIdStudent", parms);
                student.St_Id = (int)DT.Rows[0]["st_Id"];
                student.St_Fname = DT.Rows[0]["St_Fname"].ToString();
                student.Dept_Id = (int)DT.Rows[0]["Dept_Id"];
                student.St_Lname = DT.Rows[0]["St_Lname"].ToString();
                student.St_Age = (int)DT.Rows[0]["St_Age"];
                flag = true;
                return student;
                
            }
            catch (Exception)
            {
            flag = false;
            return (student);
               
            }
        }
       

        
        public static void spCorrectExam(int stId,int examNo,int crsId, QuestionList questions)
        {
            try
            {
                var parms = new Dictionary<string, object>();
                parms.Add("stId", stId);
                parms.Add("examNo", examNo);
                parms.Add("crsId", crsId);
                for (int i = 0; i < 10; i++)
                {
                    parms.Add($"ans{i + 1}", questions[i]);
                }

                object checkData = dBManager.ExecuteScaler("spCorrectExam", parms);

            }
            catch (Exception)
            {


            }
            

        }

        public static DataTable spGetByIdExamQuesWizChoices(int id)
        {
            try
            {
                var parms = new Dictionary<string, object>();
                parms.Add("examId", id);
                DataTable checkData = dBManager.ExecuteDataTable("spGetByIdExamQuesWizChoices", parms);

            }
            catch (Exception)
            {
              

            }
            return new DataTable();
        }

        #region Grades In All Crs 
        public static StdGradesList spGetByIdStdGradesInAllCrsList(int stId)
            {
             
            try
            {
                var parms = new Dictionary<string, object>();
                parms.Add("stId", stId);


                return DataTable2StdGradesList(dBManager.ExecuteDataTable("spGetByIdStdGradesInAllCrs", parms));

            }
            catch (Exception)
            {

            
            }


            return new StdGradesList();
        }

        public static StdGradesList DataTable2StdGradesList(DataTable DT)
        {
            StdGradesList stdGradesList = new StdGradesList(); 
            try
            {
                for (int i = 0; i < DT?.Rows.Count; i++)
                {
                    stdGradesList.Add(DataRow2StdGrades(DT.Rows[i]));

                }


            }
            catch (Exception)
            {

                throw;
            }
            return stdGradesList;
        }

        public static StdGrades DataRow2StdGrades(DataRow Dr)
        {
            StdGrades stdGrades = new StdGrades();
            try
            {
                stdGrades.Crs_Name = Dr["Crs_Name"]?.ToString()??"NAN";
                stdGrades.FullName = Dr["FullName"]?.ToString()??"NAN";

                if (int.TryParse(Dr["Grade"].ToString() ?? "-1", out int TempInt))
                    stdGrades.Grade = TempInt * 10;

            }
            catch
            {

            }
            return stdGrades;

        }
        #endregion

       
        #region Get Courses
        public static StdCourses spGetAllCrsOfStudent(int stdId)
        {
            StdCourses stdCourses = new StdCourses();
            try
            {
                var parms = new Dictionary<string, object>() { {"stdId", stdId } };
                DataTable DT =  dBManager.ExecuteDataTable("spGetAllCrsOfStudent", parms);

                foreach (DataRow item in DT.Rows)
                {
                    stdCourses.Courses.Add(new Course() {Crs_Id = (int) item["Crs_Id"] ,Crs_Name = item["Crs_Name"].ToString()});
                }
                return stdCourses;

            }
            catch (Exception)
            {

                
            }
            return stdCourses;
        }

        #endregion



    }
}
