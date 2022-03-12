using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OES
{
    public partial class frmReport2 : Form
    {

        SqlConnection sqlCN;
        SqlDataAdapter sqlDA;
        DataTable DT;
        string ss = ConfigurationManager.ConnectionStrings["Online_Examination_System"].ConnectionString;


        public frmReport2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmReport2_Load(object sender, EventArgs e)
        {

        }

        private void btnExecute1_Click(object sender, EventArgs e)
        {
            {
                using (sqlCN = new SqlConnection(ss))
                {
                    sqlDA = new SqlDataAdapter("Online_Examination_System.dbo.spGetByIdStdGradesInAllCrs", sqlCN);
                    sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDA.SelectCommand.Parameters.AddWithValue("@stId", textBox1.Text);
                    DT = new DataTable();
                    sqlDA.Fill(DT);
                    ReportDocument Rdc1 = new ReportDocument();
                    Rdc1.Load(@"C:\Users\EG\source\repos\OES\Reports\ReportTwoShowStudentGradesinAllExams.rpt");
                    Rdc1.SetDataSource(DT);
                    crystalReportViewer1.ReportSource = Rdc1;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
