using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace OES
{
    public partial class frmReport1 : Form
    {
        SqlConnection sqlCN;
        SqlDataAdapter sqlDA;
        DataTable DT;
        string ss = ConfigurationManager.ConnectionStrings["Online_Examination_System"].ConnectionString;
        public frmReport1()
        {
            InitializeComponent();
        }

        private void frmReport1_Load(object sender, EventArgs e)
        {
            //ReportDocument Rdc1 = new ReportDocument();
            //Rdc1.Load(@"Reports\ReportOneShowStudentData.rpt");
            //crystalReportViewer1.ReportSource = Rdc1;
        }

        private void btnExecute1_Click(object sender, EventArgs e)
        {
            using (sqlCN = new SqlConnection(ss))
            {                                                           //spGetByIdDeptStdts                  
                sqlDA = new SqlDataAdapter("Online_Examination_System.dbo.showStudentData", sqlCN);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.AddWithValue("@DeptId", textBox1.Text);
                DT = new DataTable();
                sqlDA.Fill(DT);
                ReportDocument Rdc1 = new ReportDocument();
                Rdc1.Load(@"C:\Users\EG\source\repos\OES\Reports\ReportOneShowStudentData.rpt");
                Rdc1.SetDataSource(DT);
                crystalReportViewer1.ReportSource = Rdc1;
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
