using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathLab
{
    public partial class frmTestMaster : Form
    {
        DbHelper obj = new DbHelper();
        public int TestId = 0;

        public frmTestMaster()
        {
            InitializeComponent();
        }

        private void frmTestMaster_Load(object sender, EventArgs e)
        {
            try
            {
                txtTestName.Enabled = true;
                txtUnit.Enabled = true;
                txtNormalValue.Enabled = true;
                FillTest(false);
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FillTest(bool refresh)
        {
            try
            {
                DataTable dt = obj.GetTable("select *,'' as Heading  from TestMaster");
                grdTest.AutoGenerateColumns = false;
                if (refresh)
                    grdTest.DataSource = null;
                grdTest.DataSource = dt;
                grdTest.AllowUserToAddRows = false;
                
                foreach (DataGridViewRow row in grdTest.Rows)
                {
                    bool isHeading = Convert.ToBoolean(row.Cells["IsHeading"].Value);
                    if (isHeading)
                    {
                        row.Cells["Heading"].Value = "Yes";
                    }
                    else
                    {
                        row.Cells["Heading"].Value = "No";
                    } 
                }
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Empty;
                if (this.TestId == 0)
                {
                    query = "insert into TestMaster (TestName,NormalValue,Unit,IsHeading) values ('" + txtTestName.Text + "','" + txtNormalValue.Text + "','" + txtUnit.Text + "'," + optHeading.Checked + ")";
                }
                else
                {
                    query = "update TestMaster set TestName='" + txtTestName.Text + "', NormalValue='" + txtNormalValue.Text + "', Unit='" + txtUnit.Text + "', IsHeading=" + optHeading.Checked + " where ID=" + this.TestId + "";
                }
                bool i = obj.NonQuery(query);
                btnSave.Text = "Save";
                txtNormalValue.Text = string.Empty;
                txtTestName.Text = string.Empty;
                txtUnit.Text = string.Empty;

                this.TestId = 0;
                if (i)
                {
                    FillTest(true);
                }
                else
                {
                    MessageBox.Show(obj.ExceptionInfo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void grdTest_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DbHelper objDb = new DbHelper();
                DataGridViewRow row = grdTest.Rows[e.RowIndex];
                Int32.TryParse(row.Cells["ID"].Value.ToString(), out TestId);
                DataTable dt = objDb.GetTable("select * from TestMaster where Id=" + TestId + " ");
                if (dt.Rows.Count > 0)
                {
                    txtTestName.Text = dt.Rows[0]["TestName"].ToString();
                    txtNormalValue.Text = dt.Rows[0]["NormalValue"].ToString();
                    txtUnit.Text = dt.Rows[0]["Unit"].ToString();
                    optHeading.Checked = Convert.ToBoolean(dt.Rows[0]["IsHeading"].ToString());
                    optTest.Checked = !optHeading.Checked;
                    btnSave.Text = "Update";
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
                foreach (DataGridViewRow row in grdTest.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["ChkDelete"].Value);
                    int id = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                    if (isChecked)
                    {
                        obj.NonQuery("delete from TestMaster where Id=" + id + "");
                    }
                }
                FillTest(true);
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void optTest_CheckedChanged(object sender, EventArgs e)
        {
            txtTestName.Enabled = true;
            txtUnit.Enabled = true;
            txtNormalValue.Enabled = true;
        }

        private void optHeading_CheckedChanged(object sender, EventArgs e)
        {
            txtUnit.Enabled = false;
            txtNormalValue.Enabled = false;
            txtTestName.Text = string.Empty;
            txtUnit.Text = string.Empty;
            txtNormalValue.Text = string.Empty;

        }

        private void grdTest_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.grdTest.Rows[e.RowIndex].Cells["SNO"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
