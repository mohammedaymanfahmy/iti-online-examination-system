
namespace OES
{
    partial class frmExamPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuNo = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.chkAnswers = new System.Windows.Forms.CheckedListBox();
            this.btnPrev = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.timer_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ExambindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ExambindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Question Number";
            // 
            // lblQuNo
            // 
            this.lblQuNo.AutoSize = true;
            this.lblQuNo.BackColor = System.Drawing.Color.Transparent;
            this.lblQuNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuNo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblQuNo.Location = new System.Drawing.Point(239, 39);
            this.lblQuNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuNo.Name = "lblQuNo";
            this.lblQuNo.Size = new System.Drawing.Size(25, 26);
            this.lblQuNo.TabIndex = 14;
            this.lblQuNo.Text = "1";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Gray;
            this.lblQuestion.Location = new System.Drawing.Point(59, 97);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(257, 25);
            this.lblQuestion.TabIndex = 15;
            this.lblQuestion.Text = "Waht is the Factors of GUi?";
            // 
            // chkAnswers
            // 
            this.chkAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnswers.FormattingEnabled = true;
            this.chkAnswers.Items.AddRange(new object[] {
            "one",
            "Two",
            "Three",
            "Four"});
            this.chkAnswers.Location = new System.Drawing.Point(49, 147);
            this.chkAnswers.Margin = new System.Windows.Forms.Padding(2);
            this.chkAnswers.Name = "chkAnswers";
            this.chkAnswers.Size = new System.Drawing.Size(1087, 139);
            this.chkAnswers.TabIndex = 16;
            this.chkAnswers.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnPrev.IconColor = System.Drawing.Color.SteelBlue;
            this.btnPrev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrev.IconSize = 36;
            this.btnPrev.Location = new System.Drawing.Point(161, 311);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(287, 35);
            this.btnPrev.TabIndex = 18;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.prev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnNext.IconColor = System.Drawing.Color.SteelBlue;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 36;
            this.btnNext.Location = new System.Drawing.Point(751, 311);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(258, 35);
            this.btnNext.TabIndex = 19;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.next_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1021, 432);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSubmit.Size = new System.Drawing.Size(134, 40);
            this.btnSubmit.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnSubmit.StateCommon.Back.ColorAngle = 45F;
            this.btnSubmit.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSubmit.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmit.StateCommon.Border.Rounding = 20;
            this.btnSubmit.StateCommon.Border.Width = 1;
            this.btnSubmit.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSubmit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSubmit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmit.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSubmit.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Values.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.submit_bttn_Click);
            // 
            // timer_txt
            // 
            this.timer_txt.Location = new System.Drawing.Point(972, 29);
            this.timer_txt.Margin = new System.Windows.Forms.Padding(2);
            this.timer_txt.Name = "timer_txt";
            this.timer_txt.ReadOnly = true;
            this.timer_txt.Size = new System.Drawing.Size(164, 34);
            this.timer_txt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.timer_txt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.timer_txt.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.timer_txt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.timer_txt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.timer_txt.StateCommon.Border.Rounding = 20;
            this.timer_txt.StateCommon.Border.Width = 1;
            this.timer_txt.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.timer_txt.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_txt.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.timer_txt.TabIndex = 21;
            this.timer_txt.Text = "00:00:00";
            this.timer_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timer_txt.UseMnemonic = false;
            // 
            // frmExamPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1166, 483);
            this.Controls.Add(this.timer_txt);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.chkAnswers);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQuNo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmExamPanel";
            this.Text = "Exam_Panel";
            this.Load += new System.EventHandler(this.Exam_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExambindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuNo;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.CheckedListBox chkAnswers;
        private FontAwesome.Sharp.IconButton btnPrev;
        private FontAwesome.Sharp.IconButton btnNext;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmit;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox timer_txt;
        private System.Windows.Forms.BindingSource ExambindingSource;
    }
}