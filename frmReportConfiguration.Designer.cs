namespace PathLab
{
    partial class frmReportConfiguration
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblReportMaster = new System.Windows.Forms.Label();
            this.ddlReport = new System.Windows.Forms.ComboBox();
            this.ddlTest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlHeading = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optHeading = new System.Windows.Forms.RadioButton();
            this.optTest = new System.Windows.Forms.RadioButton();
            this.gridReport = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsHeading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChkDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Report";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(155, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblReportMaster
            // 
            this.lblReportMaster.AutoSize = true;
            this.lblReportMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportMaster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblReportMaster.Location = new System.Drawing.Point(357, 22);
            this.lblReportMaster.Name = "lblReportMaster";
            this.lblReportMaster.Size = new System.Drawing.Size(147, 25);
            this.lblReportMaster.TabIndex = 14;
            this.lblReportMaster.Text = "Report Master";
            // 
            // ddlReport
            // 
            this.ddlReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlReport.FormattingEnabled = true;
            this.ddlReport.Location = new System.Drawing.Point(155, 76);
            this.ddlReport.Name = "ddlReport";
            this.ddlReport.Size = new System.Drawing.Size(203, 21);
            this.ddlReport.TabIndex = 1;
            this.ddlReport.SelectedIndexChanged += new System.EventHandler(this.ddlReport_SelectedIndexChanged);
            // 
            // ddlTest
            // 
            this.ddlTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTest.FormattingEnabled = true;
            this.ddlTest.Location = new System.Drawing.Point(155, 190);
            this.ddlTest.Name = "ddlTest";
            this.ddlTest.Size = new System.Drawing.Size(203, 21);
            this.ddlTest.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Test";
            // 
            // ddlHeading
            // 
            this.ddlHeading.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlHeading.FormattingEnabled = true;
            this.ddlHeading.Location = new System.Drawing.Point(558, 189);
            this.ddlHeading.Name = "ddlHeading";
            this.ddlHeading.Size = new System.Drawing.Size(203, 21);
            this.ddlHeading.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select Heading";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optHeading);
            this.groupBox1.Controls.Add(this.optTest);
            this.groupBox1.Location = new System.Drawing.Point(155, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 56);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // optHeading
            // 
            this.optHeading.AutoSize = true;
            this.optHeading.Location = new System.Drawing.Point(138, 19);
            this.optHeading.Name = "optHeading";
            this.optHeading.Size = new System.Drawing.Size(65, 17);
            this.optHeading.TabIndex = 21;
            this.optHeading.Text = "Heading";
            this.optHeading.UseVisualStyleBackColor = true;
            this.optHeading.CheckedChanged += new System.EventHandler(this.optHeading_CheckedChanged);
            // 
            // optTest
            // 
            this.optTest.AutoSize = true;
            this.optTest.Checked = true;
            this.optTest.Location = new System.Drawing.Point(6, 19);
            this.optTest.Name = "optTest";
            this.optTest.Size = new System.Drawing.Size(46, 17);
            this.optTest.TabIndex = 20;
            this.optTest.TabStop = true;
            this.optTest.Text = "Test";
            this.optTest.UseVisualStyleBackColor = true;
            this.optTest.CheckedChanged += new System.EventHandler(this.optTest_CheckedChanged);
            // 
            // gridReport
            // 
            this.gridReport.AllowUserToAddRows = false;
            this.gridReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNO,
            this.ID,
            this.TestName,
            this.IsHeading,
            this.Heading,
            this.ChkDelete});
            this.gridReport.Location = new System.Drawing.Point(161, 289);
            this.gridReport.Name = "gridReport";
            this.gridReport.Size = new System.Drawing.Size(600, 203);
            this.gridReport.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(791, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(362, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SNO
            // 
            this.SNO.DataPropertyName = "SNO";
            this.SNO.HeaderText = "SNO";
            this.SNO.Name = "SNO";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // TestName
            // 
            this.TestName.DataPropertyName = "TestName";
            this.TestName.HeaderText = "TestName";
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            this.TestName.Width = 200;
            // 
            // IsHeading
            // 
            this.IsHeading.DataPropertyName = "IsHeading";
            this.IsHeading.HeaderText = "IsHeading";
            this.IsHeading.Name = "IsHeading";
            this.IsHeading.ReadOnly = true;
            this.IsHeading.Visible = false;
            // 
            // Heading
            // 
            this.Heading.DataPropertyName = "Heading";
            this.Heading.HeaderText = "Heading";
            this.Heading.Name = "Heading";
            this.Heading.ReadOnly = true;
            // 
            // ChkDelete
            // 
            this.ChkDelete.HeaderText = "Delete";
            this.ChkDelete.Name = "ChkDelete";
            // 
            // frmReportConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 516);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gridReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ddlHeading);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReportMaster);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ddlReport);
            this.Controls.Add(this.label1);
            this.Name = "frmReportConfiguration";
            this.Text = "frmReportConfiguration";
            this.Load += new System.EventHandler(this.frmReportConfiguration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblReportMaster;
        private System.Windows.Forms.ComboBox ddlReport;
        private System.Windows.Forms.ComboBox ddlTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlHeading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optHeading;
        private System.Windows.Forms.RadioButton optTest;
        private System.Windows.Forms.DataGridView gridReport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsHeading;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heading;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChkDelete;
    }
}