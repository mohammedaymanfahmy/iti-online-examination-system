using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OES
{
    public partial class frmGenerateCrsExam : Form
    {
        public frmGenerateCrsExam()
        {
            InitializeComponent();
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonLabel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            int.TryParse(txtExamNo.Text.ToString() ?? "-1",  out int TempExamId);
            int.TryParse(txtDuration.Text.ToString() ?? "-1",  out int TempDuration);
            int.TryParse(txtCrsId.Text.ToString() ?? "-1",  out int TempCrsId);
            int.TryParse(txtNoOfT_F.Text.ToString() ?? "-1",  out int TempNo);
            ExamGeneration exam = new ExamGeneration() { 
                ExamNo = TempExamId, 
                examDuration = TempDuration, 
                CrsID_ = TempCrsId, 
                noTF =  TempNo
            };
            var DB = InstructorManager.spGenerateExam(exam);
            if(DB)
                MessageBox.Show("Exam Is Created");
            else
                MessageBox.Show("Exam Is Not Created Enter Valid Data");

        }

        private void kryptonLabel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
