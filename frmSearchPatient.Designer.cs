namespace PathLab
{
    partial class frmSearchPatient
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
            this.lblReportMaster = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.ddlDoctor = new System.Windows.Forms.ComboBox();
            this.ddlGender = new System.Windows.Forms.ComboBox();
            this.ddlAge = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gridPatient = new System.Windows.Forms.DataGridView();
            this.SNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferredBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // lblReportMaster
            // 
            this.lblReportMaster.AutoSize = true;
            this.lblReportMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportMaster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblReportMaster.Location = new System.Drawing.Point(335, 22);
            this.lblReportMaster.Name = "lblReportMaster";
            this.lblReportMaster.Size = new System.Drawing.Size(154, 25);
            this.lblReportMaster.TabIndex = 15;
            this.lblReportMaster.Text = "Search Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Referred By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mobile No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Gender";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(360, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 20);
            this.txtName.TabIndex = 20;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(360, 108);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(238, 20);
            this.txtMobile.TabIndex = 21;
            // 
            // ddlDoctor
            // 
            this.ddlDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDoctor.FormattingEnabled = true;
            this.ddlDoctor.Location = new System.Drawing.Point(360, 142);
            this.ddlDoctor.Name = "ddlDoctor";
            this.ddlDoctor.Size = new System.Drawing.Size(238, 21);
            this.ddlDoctor.TabIndex = 22;
            // 
            // ddlGender
            // 
            this.ddlGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlGender.FormattingEnabled = true;
            this.ddlGender.Location = new System.Drawing.Point(360, 221);
            this.ddlGender.Name = "ddlGender";
            this.ddlGender.Size = new System.Drawing.Size(238, 21);
            this.ddlGender.TabIndex = 23;
            // 
            // ddlAge
            // 
            this.ddlAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAge.FormattingEnabled = true;
            this.ddlAge.Location = new System.Drawing.Point(360, 182);
            this.ddlAge.Name = "ddlAge";
            this.ddlAge.Size = new System.Drawing.Size(238, 21);
            this.ddlAge.TabIndex = 24;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(360, 261);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridPatient
            // 
            this.gridPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNO,
            this.ID,
            this.PatientName,
            this.Age,
            this.Sex,
            this.MobileNo,
            this.ReferredBy,
            this.CreatedOn,
            this.Gender});
            this.gridPatient.Location = new System.Drawing.Point(97, 311);
            this.gridPatient.Name = "gridPatient";
            this.gridPatient.Size = new System.Drawing.Size(987, 396);
            this.gridPatient.TabIndex = 26;
            this.gridPatient.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPatient_RowHeaderMouseDoubleClick);
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
            this.ID.HeaderText = "Patient ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "Sex";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // MobileNo
            // 
            this.MobileNo.DataPropertyName = "MobileNo";
            this.MobileNo.HeaderText = "Mobile No";
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.ReadOnly = true;
            // 
            // ReferredBy
            // 
            this.ReferredBy.DataPropertyName = "DoctorName";
            this.ReferredBy.HeaderText = "Referred By";
            this.ReferredBy.Name = "ReferredBy";
            this.ReferredBy.ReadOnly = true;
            // 
            // CreatedOn
            // 
            this.CreatedOn.DataPropertyName = "CreatedDate";
            this.CreatedOn.HeaderText = "Added Date";
            this.CreatedOn.Name = "CreatedOn";
            this.CreatedOn.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Visible = false;
            // 
            // frmSearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 581);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gridPatient);
            this.Controls.Add(this.ddlAge);
            this.Controls.Add(this.ddlGender);
            this.Controls.Add(this.ddlDoctor);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReportMaster);
            this.Controls.Add(this.label1);
            this.Name = "frmSearchPatient";
            this.Text = "frmPatientMater";
            ((System.ComponentModel.ISupportInitialize)(this.gridPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReportMaster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.ComboBox ddlDoctor;
        private System.Windows.Forms.ComboBox ddlGender;
        private System.Windows.Forms.ComboBox ddlAge;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gridPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferredBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
    }
}