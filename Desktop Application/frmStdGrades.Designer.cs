
namespace OES
{
    partial class frmStdGrades
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
            this.bindingSourceGrades = new System.Windows.Forms.BindingSource(this.components);
            this.online_Examination_SystemDataSet = new OES.Online_Examination_SystemDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_Examination_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceGrades
            // 
            this.bindingSourceGrades.DataSource = this.online_Examination_SystemDataSet;
            this.bindingSourceGrades.Position = 0;
            // 
            // online_Examination_SystemDataSet
            // 
            this.online_Examination_SystemDataSet.DataSetName = "Online_Examination_SystemDataSet";
            this.online_Examination_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bindingSourceGrades;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(479, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmStdGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 283);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmStdGrades";
            this.Text = "frmStdGrades";
            this.Load += new System.EventHandler(this.frmStdGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.online_Examination_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceGrades;
        private Online_Examination_SystemDataSet online_Examination_SystemDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}