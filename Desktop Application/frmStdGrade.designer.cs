
namespace OES
{
    partial class frmStdGrade
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
            this.grade_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCrsName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prev_bttn = new FontAwesome.Sharp.IconButton();
            this.next_bttn = new FontAwesome.Sharp.IconButton();
            this.bindingSourceGrades = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // grade_txt
            // 
            this.grade_txt.Location = new System.Drawing.Point(404, 172);
            this.grade_txt.Margin = new System.Windows.Forms.Padding(2);
            this.grade_txt.Name = "grade_txt";
            this.grade_txt.ReadOnly = true;
            this.grade_txt.Size = new System.Drawing.Size(284, 33);
            this.grade_txt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.grade_txt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grade_txt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grade_txt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grade_txt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.grade_txt.StateCommon.Border.Rounding = 20;
            this.grade_txt.StateCommon.Border.Width = 1;
            this.grade_txt.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.grade_txt.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade_txt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.grade_txt.TabIndex = 15;
            // 
            // txtCrsName
            // 
            this.txtCrsName.Location = new System.Drawing.Point(404, 70);
            this.txtCrsName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCrsName.Name = "txtCrsName";
            this.txtCrsName.ReadOnly = true;
            this.txtCrsName.Size = new System.Drawing.Size(284, 33);
            this.txtCrsName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtCrsName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCrsName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCrsName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCrsName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtCrsName.StateCommon.Border.Rounding = 20;
            this.txtCrsName.StateCommon.Border.Width = 1;
            this.txtCrsName.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtCrsName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrsName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtCrsName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(163, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Grade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(163, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Course Name";
            // 
            // prev_bttn
            // 
            this.prev_bttn.BackColor = System.Drawing.Color.White;
            this.prev_bttn.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.prev_bttn.IconColor = System.Drawing.Color.SteelBlue;
            this.prev_bttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.prev_bttn.Location = new System.Drawing.Point(155, 280);
            this.prev_bttn.Margin = new System.Windows.Forms.Padding(2);
            this.prev_bttn.Name = "prev_bttn";
            this.prev_bttn.Size = new System.Drawing.Size(177, 53);
            this.prev_bttn.TabIndex = 17;
            this.prev_bttn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.prev_bttn.UseVisualStyleBackColor = false;
            this.prev_bttn.Click += new System.EventHandler(this.prev_bttn_Click);
            // 
            // next_bttn
            // 
            this.next_bttn.BackColor = System.Drawing.Color.White;
            this.next_bttn.FlatAppearance.BorderSize = 0;
            this.next_bttn.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.next_bttn.IconColor = System.Drawing.Color.SteelBlue;
            this.next_bttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.next_bttn.Location = new System.Drawing.Point(503, 280);
            this.next_bttn.Margin = new System.Windows.Forms.Padding(2);
            this.next_bttn.Name = "next_bttn";
            this.next_bttn.Size = new System.Drawing.Size(172, 53);
            this.next_bttn.TabIndex = 16;
            this.next_bttn.UseVisualStyleBackColor = false;
            this.next_bttn.Click += new System.EventHandler(this.next_bttn_Click);
            // 
            // Grades_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 344);
            this.ControlBox = false;
            this.Controls.Add(this.prev_bttn);
            this.Controls.Add(this.next_bttn);
            this.Controls.Add(this.grade_txt);
            this.Controls.Add(this.txtCrsName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Grades_panel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton prev_bttn;
        private FontAwesome.Sharp.IconButton next_bttn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox grade_txt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCrsName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceGrades;
    }
}