using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using BLL;
namespace OES
{
    public partial class frmStudent : KryptonForm
    {
        private Form current_child_form;
        private int CrsExamIndex = 0;
        private Student Student;
        public frmStudent(Student student)
        {
            InitializeComponent();
            Student = student;
            
        }

        private void Student_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome {Student.St_Fname} {Student.St_Lname}";
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Home;
        }

        private void Grades_Bttn_Click(object sender, EventArgs e)
        {
            label1.Text = "Grades";
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Poll;

        
            openchildform(new frmStdGrade(Student));
            
        }

        private void openchildform(Form new_win)
        {
            if(current_child_form!=null)
            {
                current_child_form.Close();
            }
            current_child_form = new_win;
            new_win.TopLevel = false;
            new_win.FormBorderStyle = FormBorderStyle.None;
            new_win.Dock = DockStyle.Fill;
            panel_Desktop.Controls.Add(new_win);
            panel_Desktop.Tag = new_win;
            new_win.BringToFront();
            new_win.Show();
            
        }

       

        private void strt_exam_bttn_Click_1(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            Quiz_Menu.Show(c,c.Width,0);
            
        }

        private void panel_Desktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Quiz_Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exam exam = ExamManager.spGetByNameCrsExam("C#");
            exam.CrsID = 4;

            Quiz_Menu.Close();
            label1.Text = "Exam";
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            var f = new frmExamPanel(exam, Student);

            openchildform(f);
        }

        private void oOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exam exam = ExamManager.spGetByNameCrsExam("OOP");
            exam.CrsID = 1;

            Quiz_Menu.Close();
            label1.Text = "Exam";
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            var f = new frmExamPanel(exam, Student);

            openchildform(f);

        }

        private void dSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exam exam = ExamManager.spGetByNameCrsExam("DSandALg");
            exam.CrsID = 3;

            Quiz_Menu.Close();
            label1.Text = "Exam";
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            var f = new frmExamPanel(exam, Student);

            openchildform(f);

        }

        private void dBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exam exam = ExamManager.spGetByNameCrsExam("DB");
            exam.CrsID = 2;

            Quiz_Menu.Close();
            label1.Text = "Exam";
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            var f = new frmExamPanel(exam, Student);

            openchildform(f);
        }
    }
}
