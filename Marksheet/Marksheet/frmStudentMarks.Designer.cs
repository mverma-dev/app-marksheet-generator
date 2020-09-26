namespace Marksheet
{
    partial class frmStudentMarks
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
            DataSource.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRollNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmbClasses = new System.Windows.Forms.ComboBox();
            this.grdMarks = new System.Windows.Forms.DataGridView();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRollNumber = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnLoadMarks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRollNumber
            // 
            this.lblRollNumber.AutoSize = true;
            this.lblRollNumber.Location = new System.Drawing.Point(33, 53);
            this.lblRollNumber.Name = "lblRollNumber";
            this.lblRollNumber.Size = new System.Drawing.Size(86, 17);
            this.lblRollNumber.TabIndex = 0;
            this.lblRollNumber.Text = "Roll Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(36, 20);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(42, 17);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "Class";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(126, 588);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(127, 58);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print Marksheet";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmbClasses
            // 
            this.cmbClasses.FormattingEnabled = true;
            this.cmbClasses.Location = new System.Drawing.Point(179, 17);
            this.cmbClasses.Name = "cmbClasses";
            this.cmbClasses.Size = new System.Drawing.Size(221, 24);
            this.cmbClasses.TabIndex = 9;
            this.cmbClasses.SelectedIndexChanged += new System.EventHandler(this.cmbClasses_SelectedIndexChanged);
            // 
            // grdMarks
            // 
            this.grdMarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubject,
            this.colMarks});
            this.grdMarks.Location = new System.Drawing.Point(36, 124);
            this.grdMarks.Name = "grdMarks";
            this.grdMarks.RowHeadersWidth = 51;
            this.grdMarks.RowTemplate.Height = 24;
            this.grdMarks.Size = new System.Drawing.Size(364, 429);
            this.grdMarks.TabIndex = 10;
            // 
            // colSubject
            // 
            this.colSubject.DataPropertyName = "Subject";
            this.colSubject.HeaderText = "Subject";
            this.colSubject.MinimumWidth = 6;
            this.colSubject.Name = "colSubject";
            this.colSubject.ReadOnly = true;
            // 
            // colMarks
            // 
            this.colMarks.DataPropertyName = "Marks";
            this.colMarks.HeaderText = "Marks";
            this.colMarks.MinimumWidth = 6;
            this.colMarks.Name = "colMarks";
            this.colMarks.ReadOnly = true;
            // 
            // txtRollNumber
            // 
            this.txtRollNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRollNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRollNumber.Location = new System.Drawing.Point(179, 53);
            this.txtRollNumber.Name = "txtRollNumber";
            this.txtRollNumber.Size = new System.Drawing.Size(221, 22);
            this.txtRollNumber.TabIndex = 13;
            // 
            // txtStudentName
            // 
            this.txtStudentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtStudentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStudentName.Location = new System.Drawing.Point(179, 84);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(221, 22);
            this.txtStudentName.TabIndex = 14;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // btnLoadMarks
            // 
            this.btnLoadMarks.Location = new System.Drawing.Point(422, 53);
            this.btnLoadMarks.Name = "btnLoadMarks";
            this.btnLoadMarks.Size = new System.Drawing.Size(94, 23);
            this.btnLoadMarks.TabIndex = 15;
            this.btnLoadMarks.Text = "Load Marks";
            this.btnLoadMarks.UseVisualStyleBackColor = true;
            this.btnLoadMarks.Click += new System.EventHandler(this.btnLoadMarks_Click);
            // 
            // frmStudentMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 674);
            this.Controls.Add(this.btnLoadMarks);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtRollNumber);
            this.Controls.Add(this.grdMarks);
            this.Controls.Add(this.cmbClasses);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRollNumber);
            this.Name = "frmStudentMarks";
            this.Text = "Student Marks";
            this.Load += new System.EventHandler(this.frmStudentMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRollNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.DataGridView grdMarks;
        private System.Windows.Forms.TextBox txtRollNumber;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarks;
        private System.Windows.Forms.Button btnLoadMarks;
    }
}

