using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
namespace OES
{
    public partial class frmStdExam : Form
    {
        public frmStdExam()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            QuestionList examManager = ExamManager.spLastExamInCrs(1).questions;
       
            int x = 427;
            int y = 77;
            foreach (var Ques in examManager)
            {
                ComboBox mybox = new ComboBox();
                mybox.Location = new Point(x, y);
                mybox.Size = new Size(216, 26);
                mybox.Name = "combo" + Ques.Ques_No;
                Label label = new Label();
                label.Location = new Point(0, y);
                label.Size = new Size(200, 20);
                label.Text = Ques.Ques_Desc;
                this.Controls.Add(label);
                foreach (var item in Ques.ChoiceList)
                {
                    mybox.DisplayMember = item.Choice_Desc;
                    mybox.ValueMember = item.Choice_No.ToString();
                    mybox.Items.Add(item.Choice_Desc);
                }

                y += 50;
                this.Controls.Add(mybox);
            }
          
          
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            int[] answers = { 4, 4, 3, 3, 3, 3, 1, 1, 2, 2 };
            ExamManager.spCorrectExam(2431999, 1, 1, answers);
            int Grade = ExamManager.spGetByIdStdGradeInCrs(2431999,1);
            Label label = new Label();
            label.Location = new Point(0, 0);
            label.Size = new Size(200, 20);
            label.Text = Grade.ToString();
            this.Controls.Add(label);

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var DataTabe = StudentManager.spGetAllCrsOfStudent(2431999);
            var x = DataTabe;
        }

        private void btnCrsGrades_Click(object sender, EventArgs e)
        {
            var Datatable = StudentManager.spGetByIdStdGradesInAllCrsList(2431999);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExamGeneration exam = new ExamGeneration() { ExamNo = 2, examDuration =40,CrsID_ = 1, noTF = 5 };
            var DB = InstructorManager.spGenerateExam(exam);
            var x = DB;
        }
    }
}
