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

    public partial class frmReport4 : Form
    {
        SqlConnection SqlCN;
        SqlDataAdapter SqlDA;
        DataTable DT;
        string ss = ConfigurationManager.ConnectionStrings["Online_Examination_System"].ConnectionString;

        public frmReport4()
        {
            InitializeComponent();
        }

        private void btnExecute1_Click(object sender, EventArgs e)
        {
            using (SqlCN = new SqlConnection(ss))
            {
                SqlDA = new SqlDataAdapter("Online_Examination_System.dbo.spGetTopicsOfCrs", SqlCN);
                SqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlDA.SelectCommand.Parameters.AddWithValue("@crs_ID", textBox1.Text);
                DT = new DataTable();
                SqlDA.Fill(DT);
                ReportDocument Rdc1 = new ReportDocument();
                Rdc1.Load(@"C:\Users\EG\source\repos\OES\Reports\ReportFourGerAllTopicsOfCourseByID.rpt");
                Rdc1.SetDataSource(DT);
                crystalReportViewer1.ReportSource = Rdc1;
            }
        }

        private void frmReport4_Load(object sender, EventArgs e)
        {

        }
    }
}
