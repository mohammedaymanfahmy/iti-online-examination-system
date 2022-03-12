
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public enum Index { Q_No,Q_Desc,Ch_ID,Ch_Desc}
    public static class ExamManager
    {
        private static DBManager dBManager = new DBManager();

        public static int spGetByIdStdGradeInCrs( int stdId , int crsId)
        {
            try
            {
                var parms = new Dictionary<string, object>() {
                    {"stdId",stdId },
                    {"crsId",crsId }
                };

                return (int)dBManager.ExecuteScaler("spGetByIdStdGradeInCrs", parms);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public static int spCorrectExam(int stdId,int examNo,int crsId,int[] answers)
        {
            try
            {
                Dictionary<string, object> parms = new Dictionary<string, object>() {

                    {"examNo",examNo},{"stId",stdId},{"crsId",crsId}
                };
              
                for (int i = 1; i <= answers?.Length; i++)
                {

                    parms["ans" + i] = answers[i - 1];

                }
                return dBManager.ExecuteNonQuery("spCorrectExam", parms);

            }
            catch (Exception)
            {

              
            }
            return -1;
          
        }

        #region Show exam
            public static Exam spLastExamInCrs(int crsId)
            {
                Exam exam = new Exam();
                try
                {
                    Dictionary<string, object> parms = new Dictionary<string, object>();
                    parms["crsId"] = crsId;
                    return DataTable2Exam(dBManager.ExecuteDataTable("spLastExamInCrs", parms));
                }
                catch (Exception)
                {

           
                }
                return exam;
            }

            public static Exam spGetByNameCrsExam(string crsName)
            {
                Exam exam = new Exam();
                try
                {
                    Dictionary<string, object> parms = new Dictionary<string, object>();
                    parms["crsName"] = crsName;
                    return DataTable2Exam(dBManager.ExecuteDataTable("spGetByNameCrsExam", parms));
                }
                catch (Exception)
                {


                }
                return exam;
            }
        public static Exam DataTable2Exam(DataTable DT)
            {
                try
                {
                    Exam exam = new Exam() { Exam_No = (int)(DT.Rows[0]["ExamNo"]) };
                
                    for (int i = 0; i < DT?.Rows.Count; i++)
                    {
                        int QNO = (int)DT.Rows[i]["Ques_No"];
                    
                        string QDesc = DT.Rows[i]["Ques_Desc"].ToString();
                    
                        int CNO  = (int) DT.Rows[i]["Choice_No"];

                        string CDESC = DT.Rows[i]["Choice_Desc"].ToString();

                        if (!exam.questions.Any(q=>q.Ques_No == QNO))
                            exam.questions.Add(new Question() { Ques_No = QNO,Ques_Desc = QDesc});

                        exam.questions.FirstOrDefault(q => q.Ques_No == QNO).ChoiceList.Add(new Choices() { Choice_No = CNO, Choice_Desc = CDESC });
                    }
                return exam;
                }
                catch (Exception)
                {
             
                }
                return new Exam();
            }
        #endregion


       

    }
}
