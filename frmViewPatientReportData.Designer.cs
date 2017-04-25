namespace PathLab
{
    partial class frmViewPatientReportData
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
            this.gridReport = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblReportMaster = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReportName = new System.Windows.Forms.Label();
            this.SNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NormalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeadingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsHeading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridReport)).BeginInit();
            this.SuspendLayout();
            // 
            // gridReport
            // 
            this.gridReport.AllowUserToAddRows = false;
            this.gridReport.AllowUserToDeleteRows = false;
            this.gridReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNO,
            this.TestId,
            this.TestName,
            this.Unit,
            this.NormalValue,
            this.TestValue,
            this.HeadingName,
            this.IsHeading});
            this.gridReport.Location = new System.Drawing.Point(95, 185);
            this.gridReport.Name = "gridReport";
            this.gridReport.Size = new System.Drawing.Size(1022, 351);
            this.gridReport.TabIndex = 4;
            this.gridReport.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridReport_RowPostPaint);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(403, 564);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Print Report";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Name";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(375, 87);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(0, 13);
            this.lblPatientName.TabIndex = 7;
            // 
            // lblReportMaster
            // 
            this.lblReportMaster.AutoSize = true;
            this.lblReportMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportMaster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblReportMaster.Location = new System.Drawing.Point(325, 24);
            this.lblReportMaster.Name = "lblReportMaster";
            this.lblReportMaster.Size = new System.Drawing.Size(252, 25);
            this.lblReportMaster.TabIndex = 16;
            this.lblReportMaster.Text = "View Patient Report Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Report Name";
            // 
            // lblReportName
            // 
            this.lblReportName.AutoSize = true;
            this.lblReportName.Location = new System.Drawing.Point(375, 118);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Size = new System.Drawing.Size(0, 13);
            this.lblReportName.TabIndex = 18;
            // 
            // SNO
            // 
            this.SNO.HeaderText = "SNO";
            this.SNO.Name = "SNO";
            this.SNO.ReadOnly = true;
            // 
            // TestId
            // 
            this.TestId.DataPropertyName = "TestId";
            this.TestId.HeaderText = "Test ID";
            this.TestId.Name = "TestId";
            this.TestId.ReadOnly = true;
            this.TestId.Visible = false;
            // 
            // TestName
            // 
            this.TestName.DataPropertyName = "TestName";
            this.TestName.HeaderText = "Test Name";
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // NormalValue
            // 
            this.NormalValue.DataPropertyName = "NormalValue";
            this.NormalValue.HeaderText = "Normal Value";
            this.NormalValue.Name = "NormalValue";
            this.NormalValue.ReadOnly = true;
            // 
            // TestValue
            // 
            this.TestValue.DataPropertyName = "TestedValue";
            this.TestValue.HeaderText = "Test Value";
            this.TestValue.Name = "TestValue";
            this.TestValue.ReadOnly = true;
            // 
            // HeadingName
            // 
            this.HeadingName.DataPropertyName = "Heading";
            this.HeadingName.HeaderText = "Heading";
            this.HeadingName.Name = "HeadingName";
            this.HeadingName.ReadOnly = true;
            // 
            // IsHeading
            // 
            this.IsHeading.DataPropertyName = "IsHeading";
            this.IsHeading.HeaderText = "IsHeading";
            this.IsHeading.Name = "IsHeading";
            this.IsHeading.ReadOnly = true;
            this.IsHeading.Visible = false;
            // 
            // frmViewPatientReportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 623);
            this.Controls.Add(this.lblReportName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReportMaster);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gridReport);
            this.Controls.Add(this.label1);
            this.Name = "frmViewPatientReportData";
            this.Text = "frmPatientReport";
            this.Load += new System.EventHandler(this.frmViewPatientReportData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridReport;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblReportMaster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NormalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeadingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsHeading;
    }
}