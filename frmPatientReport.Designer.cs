namespace PathLab
{
    partial class frmPatientReport
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
            this.ddlReport = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridReport = new System.Windows.Forms.DataGridView();
            this.SNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NormalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeadingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsHeading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPatientName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Name";
            // 
            // ddlReport
            // 
            this.ddlReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlReport.FormattingEnabled = true;
            this.ddlReport.Location = new System.Drawing.Point(403, 124);
            this.ddlReport.Name = "ddlReport";
            this.ddlReport.Size = new System.Drawing.Size(250, 21);
            this.ddlReport.TabIndex = 2;
            this.ddlReport.SelectedIndexChanged += new System.EventHandler(this.ddlReport_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Report";
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
            this.TestValue.HeaderText = "Test Value";
            this.TestValue.Name = "TestValue";
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
            this.IsHeading.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(403, 564);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(669, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Select Patient";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(400, 65);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(0, 20);
            this.lblPatientName.TabIndex = 7;
            // 
            // frmPatientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 623);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gridReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlReport);
            this.Controls.Add(this.label1);
            this.Name = "frmPatientReport";
            this.Text = "frmPatientReport";
            this.Load += new System.EventHandler(this.frmPatientReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridReport;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn NormalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeadingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsHeading;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPatientName;
    }
}