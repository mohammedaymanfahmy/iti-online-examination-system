
namespace OES
{
    partial class frmGenerateCrsExam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
     /*   protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtExamNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtCrsId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtNoOfT_F = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtDuration = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // txtExamNo
            // 
            this.txtExamNo.Location = new System.Drawing.Point(326, 68);
            this.txtExamNo.Name = "txtExamNo";
            this.txtExamNo.Size = new System.Drawing.Size(426, 39);
            this.txtExamNo.StateCommon.Border.Color1 = System.Drawing.Color.RoyalBlue;
            this.txtExamNo.StateCommon.Border.Color2 = System.Drawing.Color.RoyalBlue;
            this.txtExamNo.StateCommon.Border.ColorAngle = 30F;
            this.txtExamNo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExamNo.StateCommon.Border.Rounding = 25;
            this.txtExamNo.StateCommon.Border.Width = 1;
            this.txtExamNo.TabIndex = 0;
            this.txtExamNo.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(36, 68);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(136, 29);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Exam Number";
            // 
            // txtCrsId
            // 
            this.txtCrsId.Location = new System.Drawing.Point(326, 149);
            this.txtCrsId.Name = "txtCrsId";
            this.txtCrsId.Size = new System.Drawing.Size(426, 39);
            this.txtCrsId.StateCommon.Border.Color1 = System.Drawing.Color.RoyalBlue;
            this.txtCrsId.StateCommon.Border.Color2 = System.Drawing.Color.RoyalBlue;
            this.txtCrsId.StateCommon.Border.ColorAngle = 30F;
            this.txtCrsId.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCrsId.StateCommon.Border.Rounding = 25;
            this.txtCrsId.StateCommon.Border.Width = 1;
            this.txtCrsId.TabIndex = 2;
            // 
            // txtNoOfT_F
            // 
            this.txtNoOfT_F.Location = new System.Drawing.Point(326, 234);
            this.txtNoOfT_F.Name = "txtNoOfT_F";
            this.txtNoOfT_F.Size = new System.Drawing.Size(426, 39);
            this.txtNoOfT_F.StateCommon.Border.Color1 = System.Drawing.Color.RoyalBlue;
            this.txtNoOfT_F.StateCommon.Border.Color2 = System.Drawing.Color.RoyalBlue;
            this.txtNoOfT_F.StateCommon.Border.ColorAngle = 30F;
            this.txtNoOfT_F.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNoOfT_F.StateCommon.Border.Rounding = 25;
            this.txtNoOfT_F.StateCommon.Border.Width = 1;
            this.txtNoOfT_F.TabIndex = 3;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(36, 244);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(233, 29);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Number of T/F Questions";
            this.kryptonLabel2.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel2_Paint);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(36, 149);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(95, 29);
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "Course Id";
            this.kryptonLabel3.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel3_Paint);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.kryptonButton1.Location = new System.Drawing.Point(264, 427);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.RoyalBlue;
            this.kryptonButton1.OverrideDefault.Border.Color2 = System.Drawing.Color.RoyalBlue;
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideDefault.Border.Rounding = 45;
            this.kryptonButton1.OverrideDefault.Border.Width = 1;
            this.kryptonButton1.Size = new System.Drawing.Size(222, 50);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.kryptonButton1.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.RoyalBlue;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.RoyalBlue;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 45;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.RoyalBlue;
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.RoyalBlue;
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 45;
            this.kryptonButton1.StatePressed.Border.Width = 1;
            this.kryptonButton1.TabIndex = 6;
            this.kryptonButton1.Values.Text = "Create";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(326, 314);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(426, 39);
            this.txtDuration.StateCommon.Border.Color1 = System.Drawing.Color.RoyalBlue;
            this.txtDuration.StateCommon.Border.Color2 = System.Drawing.Color.RoyalBlue;
            this.txtDuration.StateCommon.Border.ColorAngle = 30F;
            this.txtDuration.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDuration.StateCommon.Border.Rounding = 25;
            this.txtDuration.StateCommon.Border.Width = 1;
            this.txtDuration.TabIndex = 7;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(36, 324);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(90, 29);
            this.kryptonLabel4.TabIndex = 8;
            this.kryptonLabel4.Values.Text = "Duration";
            // 
            // frmGenerateCrsExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.txtNoOfT_F);
            this.Controls.Add(this.txtCrsId);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtExamNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGenerateCrsExam";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtExamNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCrsId;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNoOfT_F;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDuration;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
    }
}