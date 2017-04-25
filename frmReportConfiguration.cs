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
    public partial class frmReportConfiguration : Form
    {
        DbHelper obj = new DbHelper();
        DataTable dtReport = new DataTable();

        public frmReportConfiguration()
        {
            try
            {
                dtReport.Columns.Add("ID");
                dtReport.Columns.Add("TestName");
                dtReport.Columns.Add("Heading");
                dtReport.Columns.Add("IsHeading");
                InitializeComponent();
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmReportConfiguration_Load(object sender, EventArgs e)
        {
            try
            {
                ddlHeading.Enabled = false;
                ddlTest.Enabled = true;
                FillReport();
                FillHeading();
                FillTest();
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void optTest_CheckedChanged(object sender, EventArgs e)
        {
            ddlHeading.Enabled = false;
            ddlTest.Enabled = true;
        }

        private void optHeading_CheckedChanged(object sender, EventArgs e)
        {
            ddlHeading.Enabled = true;
            ddlTest.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var ReportId = ddlReport.SelectedValue;
                foreach (DataGridViewRow row in gridReport.Rows)
                {
                    var testId = row.Cells["ID"].Value;
                    obj.NonQuery("insert into TestReportMaster (ReportId, TestID) values ('" + ReportId + "','" + testId + "')");
                }
                MessageBox.Show("Report Configuration Saved");
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FillReport()
        {
            try
            {
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

        private void FillTest()
        {
            try
            {
                obj = new DbHelper();
                DataTable dt = obj.GetTable("select * from TestMaster where IsHeading=false");
                ddlTest.DataSource = dt;
                ddlTest.DisplayMember = "TestName";
                ddlTest.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FillHeading()
        {
            try
            {
                obj = new DbHelper();
                DataTable dt = obj.GetTable("select * from TestMaster where IsHeading=true");
                ddlHeading.DataSource = dt;
                ddlHeading.DisplayMember = "TestName";
                ddlHeading.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.gridReport.AutoGenerateColumns = false;
                DataRow dr = dtReport.NewRow();
                dr["ID"] = optTest.Checked ? ddlTest.SelectedValue : ddlHeading.SelectedValue;
                dr["TestName"] = optTest.Checked ? ddlTest.GetItemText(ddlTest.SelectedItem) : ddlHeading.GetItemText(ddlHeading.SelectedItem);
                dr["Heading"] = optHeading.Checked ? "Yes" : "No";
                dtReport.Rows.Add(dr);
                dtReport.AcceptChanges();
                gridReport.DataSource = dtReport;
                int i = 1;
                foreach (DataGridViewRow row in gridReport.Rows)
                {
                    row.Cells["SNO"].Value = i;
                    i++;
                }
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
                this.gridReport.AutoGenerateColumns = false;
                DbHelper helper = new DbHelper();
                string query = "select trm.*,tm.TestName,'' as Heading,tm.IsHeading from TestReportMaster trm inner join TestMaster tm on trm.TestId=tm.Id where trm.ReportId=" + ddlReport.SelectedValue + "";
                dtReport = helper.GetTable(query);
                gridReport.DataSource = dtReport;
                int i = 1;
                foreach (DataGridViewRow row in gridReport.Rows)
                {
                    row.Cells["SNO"].Value = i;
                    if (Convert.ToBoolean(row.Cells["IsHeading"].Value) == true)
                    {
                        row.Cells["Heading"].Value = "Yes";
                    }
                    else
                    {
                        row.Cells["Heading"].Value = "No";
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.gridReport.AutoGenerateColumns = false;
                foreach (DataGridViewRow row in gridReport.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["ChkDelete"].Value);
                    if (isChecked)
                        gridReport.Rows.Remove(row);
                }
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
