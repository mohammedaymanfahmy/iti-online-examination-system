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
    public partial class frmReport6 : Form
    {
        SqlConnection sqlCN;
        SqlDataAdapter sqlDA;
        DataTable DT;
        string ss = ConfigurationManager.ConnectionStrings["Online_Examination_System"].ConnectionString;

        public frmReport6()
        {
            InitializeComponent();
        }

        private void btnExecute1_Click(object sender, EventArgs e)
        {
            using (sqlCN = new SqlConnection(ss))
            {
                sqlDA = new SqlDataAdapter("Online_Examination_System.dbo.spExamQuestions", sqlCN);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("@examNo", textBox1.Text);
                sqlDA.SelectCommand.Parameters.AddWithValue("@stdId", textBox2.Text);

                DT = new DataTable();
                sqlDA.Fill(DT);
                ReportDocument Rdc1 = new ReportDocument();
                Rdc1.Load(@"C:\Users\EG\source\repos\OES\Reports\ReportSexShowExamWithQuestionAndStudentAnswersAndModelAnsower.rpt");
                Rdc1.SetDataSource(DT);
                crystalReportViewer1.ReportSource = Rdc1;
            }
        }
    }
}
