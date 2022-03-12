
namespace OES
{
    partial class frmStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.panelMenue = new System.Windows.Forms.Panel();
            this.btnExams = new FontAwesome.Sharp.IconButton();
            this.btnGrades = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel_Desktop = new System.Windows.Forms.Panel();
            this.Quiz_Menu = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.Quiz_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenue
            // 
            this.panelMenue.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenue.Controls.Add(this.btnExams);
            this.panelMenue.Controls.Add(this.btnGrades);
            this.panelMenue.Controls.Add(this.pictureBox1);
            this.panelMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenue.Location = new System.Drawing.Point(0, 0);
            this.panelMenue.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenue.Name = "panelMenue";
            this.panelMenue.Size = new System.Drawing.Size(182, 474);
            this.panelMenue.TabIndex = 0;
            // 
            // btnExams
            // 
            this.btnExams.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExams.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExams.FlatAppearance.BorderSize = 0;
            this.btnExams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExams.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExams.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnExams.IconColor = System.Drawing.Color.White;
            this.btnExams.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExams.IconSize = 40;
            this.btnExams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExams.Location = new System.Drawing.Point(0, 284);
            this.btnExams.Margin = new System.Windows.Forms.Padding(2);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(182, 96);
            this.btnExams.TabIndex = 2;
            this.btnExams.Text = "Start Exam";
            this.btnExams.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExams.UseVisualStyleBackColor = false;
            this.btnExams.Click += new System.EventHandler(this.strt_exam_bttn_Click_1);
            // 
            // btnGrades
            // 
            this.btnGrades.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGrades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrades.FlatAppearance.BorderSize = 0;
            this.btnGrades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrades.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGrades.IconChar = FontAwesome.Sharp.IconChar.Poll;
            this.btnGrades.IconColor = System.Drawing.Color.White;
            this.btnGrades.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGrades.IconSize = 40;
            this.btnGrades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrades.Location = new System.Drawing.Point(0, 189);
            this.btnGrades.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(182, 95);
            this.btnGrades.TabIndex = 1;
            this.btnGrades.Text = "Grades";
            this.btnGrades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrades.UseVisualStyleBackColor = false;
            this.btnGrades.Click += new System.EventHandler(this.Grades_Bttn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::OES.Properties.Resources.education;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(182, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 49);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.NodeJs;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 43;
            this.iconPictureBox1.Location = new System.Drawing.Point(14, 5);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(43, 44);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel_Desktop
            // 
            this.panel_Desktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Desktop.Location = new System.Drawing.Point(182, 49);
            this.panel_Desktop.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Desktop.Name = "panel_Desktop";
            this.panel_Desktop.Size = new System.Drawing.Size(631, 425);
            this.panel_Desktop.TabIndex = 2;
            this.panel_Desktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Desktop_Paint);
            // 
            // Quiz_Menu
            // 
            this.Quiz_Menu.BackColor = System.Drawing.Color.SteelBlue;
            this.Quiz_Menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Quiz_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Quiz_Menu.IsMainMenu = false;
            this.Quiz_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.oOPToolStripMenuItem,
            this.dSToolStripMenuItem,
            this.dBToolStripMenuItem});
            this.Quiz_Menu.MenuItemHeight = 25;
            this.Quiz_Menu.MenuItemTextColor = System.Drawing.Color.White;
            this.Quiz_Menu.Name = "Quiz_Menu";
            this.Quiz_Menu.PrimaryColor = System.Drawing.Color.Empty;
            this.Quiz_Menu.Size = new System.Drawing.Size(100, 92);
            this.Quiz_Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Quiz_Menu_ItemClicked);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.cToolStripMenuItem.Text = "C#";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // oOPToolStripMenuItem
            // 
            this.oOPToolStripMenuItem.Name = "oOPToolStripMenuItem";
            this.oOPToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.oOPToolStripMenuItem.Text = "OOP";
            this.oOPToolStripMenuItem.Click += new System.EventHandler(this.oOPToolStripMenuItem_Click);
            // 
            // dSToolStripMenuItem
            // 
            this.dSToolStripMenuItem.Name = "dSToolStripMenuItem";
            this.dSToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.dSToolStripMenuItem.Text = "DS";
            this.dSToolStripMenuItem.Click += new System.EventHandler(this.dSToolStripMenuItem_Click);
            // 
            // dBToolStripMenuItem
            // 
            this.dBToolStripMenuItem.Name = "dBToolStripMenuItem";
            this.dBToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.dBToolStripMenuItem.Text = "DB";
            this.dBToolStripMenuItem.Click += new System.EventHandler(this.dBToolStripMenuItem_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 474);
            this.Controls.Add(this.panel_Desktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStudent";
            this.Text = "Admin Home";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panelMenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.Quiz_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnExams;
        private FontAwesome.Sharp.IconButton btnGrades;
        private System.Windows.Forms.Panel panel_Desktop;
        private System.Windows.Forms.Label label1;
        public FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oOPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBToolStripMenuItem;
        public RJCodeAdvance.RJControls.RJDropdownMenu Quiz_Menu;
    }
}