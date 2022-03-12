using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class InstructorManager
    {
        static DBManager dBManager = new DBManager();

        //Login 
        public static bool spGetByIdInstructor(int id)
        {
            try
            {
                Dictionary<string, object> parms = new Dictionary<string, object>();
                parms["InsId"] = id;
                DataTable checkData =  dBManager.ExecuteDataTable("spGetByIdInstructor",parms);
                if (checkData != null)
                    return true;
            }
            catch 
            {

            }
            return false;
        }

        public static bool spGenerateExam(ExamGeneration exam)
        {
            try
            {
                PropertyInfo[] properties = typeof(ExamGeneration).GetProperties();

                Dictionary<string, object> parms = new Dictionary<string, object>();

                foreach (PropertyInfo property in properties)
                {
                    parms[property.Name] = property.GetValue(exam);
                }

                dBManager.ExecuteNonQuery("spGenerateExam", parms);
                return true;
            }
            catch 
            {
                return false;

             
            }
        }
    }
}
