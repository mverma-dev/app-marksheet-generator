namespace Marksheet
{
    partial class frmConfiguration
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
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtExcelFile = new System.Windows.Forms.TextBox();
            this.btnBrowseExcelFile = new System.Windows.Forms.Button();
            this.btnBrowseLogoFile = new System.Windows.Forms.Button();
            this.txtLogoFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSheetNamePrefix = new System.Windows.Forms.TextBox();
            this.txtInitSheetName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excel File *";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtExcelFile
            // 
            this.txtExcelFile.Location = new System.Drawing.Point(183, 23);
            this.txtExcelFile.Name = "txtExcelFile";
            this.txtExcelFile.Size = new System.Drawing.Size(423, 22);
            this.txtExcelFile.TabIndex = 1;
            // 
            // btnBrowseExcelFile
            // 
            this.btnBrowseExcelFile.Location = new System.Drawing.Point(635, 22);
            this.btnBrowseExcelFile.Name = "btnBrowseExcelFile";
            this.btnBrowseExcelFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseExcelFile.TabIndex = 2;
            this.btnBrowseExcelFile.Text = "Browse";
            this.btnBrowseExcelFile.UseVisualStyleBackColor = true;
            // 
            // btnBrowseLogoFile
            // 
            this.btnBrowseLogoFile.Location = new System.Drawing.Point(635, 67);
            this.btnBrowseLogoFile.Name = "btnBrowseLogoFile";
            this.btnBrowseLogoFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLogoFile.TabIndex = 5;
            this.btnBrowseLogoFile.Text = "Browse";
            this.btnBrowseLogoFile.UseVisualStyleBackColor = true;
            // 
            // txtLogoFile
            // 
            this.txtLogoFile.Location = new System.Drawing.Point(183, 68);
            this.txtLogoFile.Name = "txtLogoFile";
            this.txtLogoFile.Size = new System.Drawing.Size(423, 22);
            this.txtLogoFile.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Logo File *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fields marked as * are mandatory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Class Sheet Name Prefix (Default - Class)";
            // 
            // txtSheetNamePrefix
            // 
            this.txtSheetNamePrefix.Location = new System.Drawing.Point(305, 116);
            this.txtSheetNamePrefix.Name = "txtSheetNamePrefix";
            this.txtSheetNamePrefix.Size = new System.Drawing.Size(235, 22);
            this.txtSheetNamePrefix.TabIndex = 8;
            // 
            // txtInitSheetName
            // 
            this.txtInitSheetName.Location = new System.Drawing.Point(305, 189);
            this.txtInitSheetName.Name = "txtInitSheetName";
            this.txtInitSheetName.Size = new System.Drawing.Size(235, 22);
            this.txtInitSheetName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Class Sheet Name Prefix (Default - Class)";
            // 
            // frmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 339);
            this.Controls.Add(this.txtInitSheetName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSheetNamePrefix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseLogoFile);
            this.Controls.Add(this.txtLogoFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseExcelFile);
            this.Controls.Add(this.txtExcelFile);
            this.Controls.Add(this.label1);
            this.Name = "frmConfiguration";
            this.Text = "frmConfiguration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtExcelFile;
        private System.Windows.Forms.Button btnBrowseExcelFile;
        private System.Windows.Forms.Button btnBrowseLogoFile;
        private System.Windows.Forms.TextBox txtLogoFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSheetNamePrefix;
        private System.Windows.Forms.TextBox txtInitSheetName;
        private System.Windows.Forms.Label label5;
    }
}