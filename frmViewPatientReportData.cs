using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PathLab
{
    public partial class frmViewPatientReportData : Form
    {
        public static int PatientReportMasterId = 0;

        public frmViewPatientReportData()
        {
            InitializeComponent();
        }

        public frmViewPatientReportData(int patientReportMasterId)
        {
            InitializeComponent();
            PatientReportMasterId = patientReportMasterId;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                frmReport objReport = new frmReport(PatientReportMasterId);
                objReport.MdiParent = this.MdiParent;
                objReport.WindowState = FormWindowState.Maximized;
                objReport.Show();
                this.Close();
            }
            catch (Exception ex)
            { 
            }
        }

        private void frmViewPatientReportData_Load(object sender, EventArgs e)
        {
            FillReport();
        }

        private void FillReport()
        {
            try
            {
                DbHelper obj = new DbHelper();
                string query = "SELECT pm.PatientName, prm.ReportId, prm.PatientId, prm.ID AS prmId, rm.Name AS ReportName FROM  ((PatientReportMaster prm INNER JOIN                          PatientMaster pm ON prm.PatientId = pm.ID) INNER JOIN  ReportMaster rm ON prm.ReportId = rm.ID) where prm.ID=" + PatientReportMasterId;
                DataTable dt = obj.GetTable(query);
                if (dt.Rows.Count > 0)
                {
                    lblPatientName.Text = Convert.ToString(dt.Rows[0]["PatientName"]);
                    lblReportName.Text = Convert.ToString(dt.Rows[0]["ReportName"]);
                    
                    DataTable dtReort = new DataTable();
                    dtReort.Columns.Add("TestName");
                    dtReort.Columns.Add("Unit");
                    dtReort.Columns.Add("NormalValue");
                    dtReort.Columns.Add("TestedValue");
                    dtReort.Columns.Add("TestID");
                    dtReort.Columns.Add("ReportID");
                    dtReort.Columns.Add("IsHeading");
                    dtReort.Columns.Add("Heading");
                    int reportId = Convert.ToInt32(dt.Rows[0]["ReportId"]);
                    obj = new DbHelper();
                    DataTable dtTestReport = obj.GetTable("select * from TestReportMaster where ReportId=" + reportId + " ");
                    foreach (DataRow dr in dtTestReport.Rows)
                    {
                        DbHelper newobj = new DbHelper();
                        DataTable dtTest = newobj.GetTable("select *,'' as 'Heading' from TestMaster Where id=" + dr["TestId"].ToString() + " ");
                        foreach (DataRow drow in dtTest.Rows)
                        {
                            string testedValue = obj.GetScaler("select TestValue from PatientTestReportValue where PatientReportId=" + PatientReportMasterId + " and ReportId=" + reportId + " and TestID=" + dr["TestId"].ToString() + "") + "";

                            DataRow row = dtReort.NewRow();
                            row["TestName"] = drow["TestName"].ToString();
                            row["Unit"] = drow["Unit"].ToString();
                            row["NormalValue"] = drow["NormalValue"].ToString();
                            row["TestedValue"] = testedValue;
                            row["TestID"] = drow["Id"].ToString();
                            row["ReportID"] = reportId;
                            if (Convert.ToBoolean(drow["IsHeading"]) == true)
                            {
                                row["Heading"] = "Yes";
                            }
                            else
                            {
                                row["Heading"] = "No";
                            }
                            dtReort.Rows.Add(row);
                        }
                    }
                    dtReort.AcceptChanges();
                    gridReport.AutoGenerateColumns = false;
                    gridReport.DataSource = dtReort;
                    
                    foreach (DataGridViewRow row in gridReport.Rows)
                    {                       
                        if (row.Cells["HeadingName"].Value.ToString() == "Yes")
                        {
                            row.Cells["TestValue"].ReadOnly = true;
                        };
                       
                    }
                }

            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridReport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.gridReport.Rows[e.RowIndex].Cells["SNO"].Value = (e.RowIndex + 1).ToString();
        }

    }
}
