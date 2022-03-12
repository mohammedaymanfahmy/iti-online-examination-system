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
    public partial class frmStdGrade : Form
    {
        private DataTable grades; 
        public frmStdGrade(Student student)
        {
            InitializeComponent();
            var grades = StudentManager.spGetByIdStdGradesInAllCrsList(student.St_Id);
            bindingSourceGrades.DataSource = grades;
            txtCrsName.DataBindings.Add("Text", bindingSourceGrades, "Crs_Name");
            grade_txt.DataBindings.Add("Text", bindingSourceGrades, "Grade");

        }

        private void next_bttn_Click(object sender, EventArgs e)
        {
            bindingSourceGrades.MoveNext();
        }

        private void prev_bttn_Click(object sender, EventArgs e)
        {
            bindingSourceGrades.MovePrevious();

        }
    }
}
