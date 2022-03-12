
namespace OES
{
    partial class frmStdExam
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
            this.btnButton = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnCrsGrades = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(686, 270);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(75, 23);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "Save";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(531, 270);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnCrsGrades
            // 
            this.btnCrsGrades.Location = new System.Drawing.Point(367, 269);
            this.btnCrsGrades.Name = "btnCrsGrades";
            this.btnCrsGrades.Size = new System.Drawing.Size(75, 23);
            this.btnCrsGrades.TabIndex = 2;
            this.btnCrsGrades.Text = "CrsGrades";
            this.btnCrsGrades.UseVisualStyleBackColor = true;
            this.btnCrsGrades.Click += new System.EventHandler(this.btnCrsGrades_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmStdExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCrsGrades);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnButton);
            this.Name = "frmStdExam";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnCrsGrades;
        private System.Windows.Forms.Button button1;
    }
}

