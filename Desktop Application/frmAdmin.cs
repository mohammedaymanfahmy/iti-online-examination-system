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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void loadform(object Form)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            loadform(new frmGenerateCrsExam());
        }

        private void kryptonDropButton2_Click(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            rjDropdownMenu1.Show(c,c.Width,0);
        }

        private void rjDropdownMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void rjDropdownMenu1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            rjDropdownMenu1.Close();
            /*loadform(new Form3());*/
        }

        private void report4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmReport4());
        }

        private void report1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmReport1());
        }

        private void report2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmReport2());

        }

        private void report3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmReport3());

        }

        private void report5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmReport5());

        }

        private void report6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmReport6());

        }
    }
}
