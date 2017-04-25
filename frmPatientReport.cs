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
    public partial class frmPatientReport : Form
    {
        public static int PatientId = 0;

        public static int ReportId = 0;

        public frmPatientReport()
        {
            InitializeComponent();
        }

        public frmPatientReport(int patientId)
        {
            InitializeComponent();
            PatientId = patientId;
        }

        private void FillReport()
        {
            try
            {
                DbHelper obj = new DbHelper();
                DataTable dt = obj.GetTable("select * from ReportMaster");
                ddlReport.DataSource = dt;
                DataRow dr = dt.NewRow();
                dr["ID"] = 0;
                dr["Name"] = "Select";
                dt.Rows.Add(dr);
                ddlReport.DisplayMember = "Name";
                ddlReport.ValueMember = "Id";
                ddlReport.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmPatientReport_Load(object sender, EventArgs e)
        {
            try
            {
                DbHelper db = new DbHelper();
                string name = db.GetScaler("select PatientName from PatientMaster where ID=" + PatientId + " ") + "";
                lblPatientName.Text = name;
                FillReport();
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ddlReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DbHelper obj = new DbHelper();
                if (ddlReport.SelectedIndex > 0)
                {
                    DataTable dtReort = new DataTable();
                    dtReort.Columns.Add("TestName");
                    dtReort.Columns.Add("Unit");
                    dtReort.Columns.Add("NormalValue");
                    dtReort.Columns.Add("TestedValue");
                    dtReort.Columns.Add("TestID");
                    dtReort.Columns.Add("ReportID");
                    dtReort.Columns.Add("IsHeading");
                    dtReort.Columns.Add("Heading");
                    var reportId = ddlReport.SelectedValue;
                    DataTable dt = obj.GetTable("select * from TestReportMaster where ReportId=" + reportId + " ");
                    foreach (DataRow dr in dt.Rows)
                    {
                        DbHelper newobj = new DbHelper();
                        DataTable dtTest = newobj.GetTable("select *,'' as 'Heading' from TestMaster Where id=" + dr["TestId"].ToString() + " ");
                        foreach (DataRow drow in dtTest.Rows)
                        {
                            DataRow row = dtReort.NewRow();
                            row["TestName"] = drow["TestName"].ToString();
                            row["Unit"] = drow["Unit"].ToString();
                            row["NormalValue"] = drow["NormalValue"].ToString();
                            row["TestedValue"] = "";
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
                    int i = 1;
                    foreach (DataGridViewRow row in gridReport.Rows)
                    {
                        row.Cells["SNO"].Value = i;
                        if (row.Cells["HeadingName"].Value.ToString() == "Yes")
                        {
                            row.Cells["TestValue"].ReadOnly = true;
                        };
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DbHelper obj = new DbHelper();
                bool i = obj.NonQuery("insert into PatientReportMaster (PatientId, ReportId) values (" + PatientId + "," + Convert.ToInt32(ddlReport.SelectedValue) + ")");
                int patientReportId = Convert.ToInt32(obj.GetScaler("select max(ID) from PatientReportMaster"));
                bool flag;
                foreach (DataGridViewRow row in gridReport.Rows)
                {
                    int TestId = Convert.ToInt32(row.Cells["TestId"].Value);
                    string TestValue = Convert.ToString(row.Cells["TestValue"].Value);
                    string TestUnit = Convert.ToString(row.Cells["Unit"].Value);
                    flag = obj.NonQuery("insert into PatientTestReportValue (PatientReportID,ReportID, TestID, TestValue, TestUnit) values (" + patientReportId + "," + Convert.ToInt32(ddlReport.SelectedValue) + "," + TestId + ",'" + TestValue + "','" + TestUnit + "')");
                    if (flag == false)
                    {
                        string message = "Error Occurred " +obj.ExceptionInfo;
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                frmReport objReport = new frmReport(patientReportId);
                objReport.MdiParent = this.MdiParent;
                objReport.WindowState = FormWindowState.Maximized;
                objReport.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSearchPatient objfrmSearchPatient = new frmSearchPatient();
            objfrmSearchPatient.Show();
            
        }
    }
}
