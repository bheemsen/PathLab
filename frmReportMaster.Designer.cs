namespace PathLab
{
    partial class frmReportMaster
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
            this.txtReportName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblReportMaster = new System.Windows.Forms.Label();
            this.lblHasTable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.rbtYes = new System.Windows.Forms.RadioButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChkDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report Name";
            // 
            // txtReportName
            // 
            this.txtReportName.Location = new System.Drawing.Point(256, 95);
            this.txtReportName.Name = "txtReportName";
            this.txtReportName.Size = new System.Drawing.Size(285, 20);
            this.txtReportName.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(256, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.HasTable,
            this.SNO,
            this.ReportName,
            this.IsTable,
            this.ChkDelete});
            this.dataGridView1.Location = new System.Drawing.Point(141, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 236);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(366, 188);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(466, 188);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblReportMaster
            // 
            this.lblReportMaster.AutoSize = true;
            this.lblReportMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportMaster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblReportMaster.Location = new System.Drawing.Point(294, 26);
            this.lblReportMaster.Name = "lblReportMaster";
            this.lblReportMaster.Size = new System.Drawing.Size(147, 25);
            this.lblReportMaster.TabIndex = 13;
            this.lblReportMaster.Text = "Report Master";
            // 
            // lblHasTable
            // 
            this.lblHasTable.AutoSize = true;
            this.lblHasTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasTable.Location = new System.Drawing.Point(138, 124);
            this.lblHasTable.Name = "lblHasTable";
            this.lblHasTable.Size = new System.Drawing.Size(73, 17);
            this.lblHasTable.TabIndex = 14;
            this.lblHasTable.Text = "Has Table";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtNo);
            this.groupBox1.Controls.Add(this.rbtYes);
            this.groupBox1.Location = new System.Drawing.Point(256, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 42);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.Checked = true;
            this.rbtNo.Location = new System.Drawing.Point(68, 16);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(39, 17);
            this.rbtNo.TabIndex = 1;
            this.rbtNo.TabStop = true;
            this.rbtNo.Text = "No";
            this.rbtNo.UseVisualStyleBackColor = true;
            // 
            // rbtYes
            // 
            this.rbtYes.AutoSize = true;
            this.rbtYes.Location = new System.Drawing.Point(0, 16);
            this.rbtYes.Name = "rbtYes";
            this.rbtYes.Size = new System.Drawing.Size(43, 17);
            this.rbtYes.TabIndex = 0;
            this.rbtYes.TabStop = true;
            this.rbtYes.Text = "Yes";
            this.rbtYes.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 300;
            // 
            // HasTable
            // 
            this.HasTable.DataPropertyName = "HasTable";
            this.HasTable.HeaderText = "HasTable";
            this.HasTable.Name = "HasTable";
            this.HasTable.Visible = false;
            // 
            // SNO
            // 
            this.SNO.DataPropertyName = "SNO";
            this.SNO.HeaderText = "SNO";
            this.SNO.Name = "SNO";
            this.SNO.ReadOnly = true;
            // 
            // ReportName
            // 
            this.ReportName.DataPropertyName = "Name";
            this.ReportName.HeaderText = "Report Name";
            this.ReportName.Name = "ReportName";
            this.ReportName.ReadOnly = true;
            this.ReportName.Width = 200;
            // 
            // IsTable
            // 
            this.IsTable.DataPropertyName = "IsTable";
            this.IsTable.HeaderText = "IsTable";
            this.IsTable.Name = "IsTable";
            this.IsTable.ReadOnly = true;
            // 
            // ChkDelete
            // 
            this.ChkDelete.HeaderText = "Delete";
            this.ChkDelete.Name = "ChkDelete";
            // 
            // frmReportMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHasTable);
            this.Controls.Add(this.lblReportMaster);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtReportName);
            this.Controls.Add(this.label1);
            this.Name = "frmReportMaster";
            this.Text = "Report Master";
            this.Load += new System.EventHandler(this.frmTestMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReportName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblReportMaster;
        private System.Windows.Forms.Label lblHasTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtNo;
        private System.Windows.Forms.RadioButton rbtYes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HasTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsTable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChkDelete;
    }
}

