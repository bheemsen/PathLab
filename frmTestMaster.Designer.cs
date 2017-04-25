namespace PathLab
{
    partial class frmTestMaster
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtNormalValue = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grdTest = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NormalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChkDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsHeading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTestMaster = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.optTest = new System.Windows.Forms.RadioButton();
            this.optHeading = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Normal Value";
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(350, 113);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(283, 20);
            this.txtTestName.TabIndex = 4;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(350, 156);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(283, 20);
            this.txtUnit.TabIndex = 7;
            // 
            // txtNormalValue
            // 
            this.txtNormalValue.Location = new System.Drawing.Point(350, 198);
            this.txtNormalValue.Name = "txtNormalValue";
            this.txtNormalValue.Size = new System.Drawing.Size(283, 20);
            this.txtNormalValue.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(350, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grdTest
            // 
            this.grdTest.AllowUserToAddRows = false;
            this.grdTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SNo,
            this.TestName,
            this.NormalValue,
            this.Unit,
            this.Heading,
            this.ChkDelete,
            this.IsHeading});
            this.grdTest.Location = new System.Drawing.Point(109, 315);
            this.grdTest.Name = "grdTest";
            this.grdTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTest.Size = new System.Drawing.Size(801, 404);
            this.grdTest.TabIndex = 10;
            this.grdTest.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdTest_RowHeaderMouseDoubleClick);
            this.grdTest.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grdTest_RowPostPaint);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // SNo
            // 
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "SNo";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            // 
            // TestName
            // 
            this.TestName.DataPropertyName = "TestName";
            this.TestName.HeaderText = "TestName";
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            // 
            // NormalValue
            // 
            this.NormalValue.DataPropertyName = "NormalValue";
            this.NormalValue.HeaderText = "NormalValue";
            this.NormalValue.Name = "NormalValue";
            this.NormalValue.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Heading
            // 
            this.Heading.DataPropertyName = "Heading";
            this.Heading.HeaderText = "Heading";
            this.Heading.Name = "Heading";
            // 
            // ChkDelete
            // 
            this.ChkDelete.HeaderText = "Delete";
            this.ChkDelete.Name = "ChkDelete";
            // 
            // IsHeading
            // 
            this.IsHeading.DataPropertyName = "IsHeading";
            this.IsHeading.HeaderText = "IsHeading";
            this.IsHeading.Name = "IsHeading";
            this.IsHeading.Visible = false;
            // 
            // lblTestMaster
            // 
            this.lblTestMaster.AutoSize = true;
            this.lblTestMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestMaster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTestMaster.Location = new System.Drawing.Point(367, 9);
            this.lblTestMaster.Name = "lblTestMaster";
            this.lblTestMaster.Size = new System.Drawing.Size(127, 25);
            this.lblTestMaster.TabIndex = 11;
            this.lblTestMaster.Text = "Test Master";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(552, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // optTest
            // 
            this.optTest.AutoSize = true;
            this.optTest.Checked = true;
            this.optTest.Location = new System.Drawing.Point(6, 24);
            this.optTest.Name = "optTest";
            this.optTest.Size = new System.Drawing.Size(46, 17);
            this.optTest.TabIndex = 13;
            this.optTest.TabStop = true;
            this.optTest.Text = "Test";
            this.optTest.UseVisualStyleBackColor = true;
            this.optTest.CheckedChanged += new System.EventHandler(this.optTest_CheckedChanged);
            // 
            // optHeading
            // 
            this.optHeading.AutoSize = true;
            this.optHeading.Location = new System.Drawing.Point(190, 24);
            this.optHeading.Name = "optHeading";
            this.optHeading.Size = new System.Drawing.Size(87, 17);
            this.optHeading.TabIndex = 14;
            this.optHeading.TabStop = true;
            this.optHeading.Text = "Sub Heading";
            this.optHeading.UseVisualStyleBackColor = true;
            this.optHeading.CheckedChanged += new System.EventHandler(this.optHeading_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optTest);
            this.groupBox1.Controls.Add(this.optHeading);
            this.groupBox1.Location = new System.Drawing.Point(350, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 54);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // frmTestMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTestMaster);
            this.Controls.Add(this.grdTest);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNormalValue);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmTestMaster";
            this.Text = "Test Master";
            this.Load += new System.EventHandler(this.frmTestMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtNormalValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView grdTest;
        private System.Windows.Forms.Label lblTestMaster;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton optTest;
        private System.Windows.Forms.RadioButton optHeading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NormalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heading;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChkDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsHeading;
    }
}

