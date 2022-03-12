using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using BLL;

namespace OES
{
    public partial class frmLogin : KryptonForm
    {
        private string StdPassword = "iti_std";
        private string InsPassword = "iti_ins";
      
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_bttn_Click(object sender, EventArgs e)
        {
            string Password = this.txtPassword.Text;
            if (int.TryParse(this.txtUserName.Text, out int UserName))
            {
                Student Student = StudentManager.spGetByIdStudent(UserName, out bool flag);
                if (Password.Equals(StdPassword) && flag)
                {


                    this.Hide();
                    var form2 = new frmStudent(Student);
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
                else if (InstructorManager.spGetByIdInstructor(UserName) && Password == InsPassword)
                {
                    // Call Admin Page
                  
                    this.Hide();
                    var form2 = new frmAdmin();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
                else
                {
                    // Ask him To enter The Password and UserName again.
                }
            }
        }
    }
}
