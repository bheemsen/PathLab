namespace PathLab
{
    partial class frmReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dsReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsReport = new PathLab.dsReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsReportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsReportBindingSource1
            // 
            this.dsReportBindingSource1.DataSource = this.dsReport;
            this.dsReportBindingSource1.Position = 0;
            // 
            // dsReport
            // 
            this.dsReport.DataSetName = "dsReport";
            this.dsReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dsReportBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PathLab.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1163, 483);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsReportBindingSource
            // 
            this.dsReportBindingSource.DataMember = "dsReport";
            this.dsReportBindingSource.DataSource = this.dsReport;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 587);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsReportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsReportBindingSource;
        private dsReport dsReport;
        private System.Windows.Forms.BindingSource dsReportBindingSource1;


    }
}