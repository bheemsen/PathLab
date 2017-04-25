namespace PathLab
{
    partial class frmDoctorMaster
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
            this.lblDoctorMaster = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gridDoctor = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDoctorMaster
            // 
            this.lblDoctorMaster.AutoSize = true;
            this.lblDoctorMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorMaster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDoctorMaster.Location = new System.Drawing.Point(310, 16);
            this.lblDoctorMaster.Name = "lblDoctorMaster";
            this.lblDoctorMaster.Size = new System.Drawing.Size(147, 25);
            this.lblDoctorMaster.TabIndex = 0;
            this.lblDoctorMaster.Text = "Doctor Master";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(165, 91);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(165, 140);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(91, 17);
            this.lblDoctorName.TabIndex = 2;
            this.lblDoctorName.Text = "Doctor Name";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(315, 90);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(242, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(315, 139);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(242, 20);
            this.txtDoctorName.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(315, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridDoctor
            // 
            this.gridDoctor.AllowUserToAddRows = false;
            this.gridDoctor.AllowUserToDeleteRows = false;
            this.gridDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.ID,
            this.Title,
            this.DoctorName});
            this.gridDoctor.Location = new System.Drawing.Point(168, 236);
            this.gridDoctor.Name = "gridDoctor";
            this.gridDoctor.ReadOnly = true;
            this.gridDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDoctor.Size = new System.Drawing.Size(516, 150);
            this.gridDoctor.TabIndex = 6;
            this.gridDoctor.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridDoctor_RowHeaderMouseDoubleClick);
            this.gridDoctor.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridDoctor_RowPostPaint);
            this.gridDoctor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridDoctor_MouseDoubleClick);
            // 
            // SNo
            // 
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "S.No";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // DoctorName
            // 
            this.DoctorName.DataPropertyName = "DoctorName";
            this.DoctorName.HeaderText = "Doctor Name";
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.ReadOnly = true;
            this.DoctorName.Width = 200;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(482, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDoctorMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 425);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gridDoctor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDoctorMaster);
            this.Name = "frmDoctorMaster";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.frmDoctorMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoctorMaster;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gridDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.Button btnDelete;
    }
}