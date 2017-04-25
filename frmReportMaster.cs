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
    public partial class frmReportMaster : Form
    {

        public int ReportId = 0;

        public frmReportMaster()
        {
            InitializeComponent();
        }

        private void frmTestMaster_Load(object sender, EventArgs e)
        {
            try
            {
                BindGrid();

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
                DbHelper obj = new DbHelper();
                if (txtReportName.Text == string.Empty)
                {
                    MessageBox.Show("Please fill report name");
                }
                else
                {
                    string query = string.Empty;
                    if (ReportId > 0)
                    {
                        query = "update ReportMaster set Name='" + txtReportName.Text + "', HasTable=" + rbtYes.Checked + " where Id=" + ReportId + "";
                    }
                    else
                    {
                        query = "insert into ReportMaster (Name,HasTable) values ('" + txtReportName.Text + "'," + rbtYes.Checked + ")";
                    }
                    bool i = obj.NonQuery(query);
                    if (i)
                    {
                        txtReportName.Text = string.Empty;
                        BindGrid();
                        btnSave.Text = "Text";
                    }
                    else
                    {
                        MessageBox.Show(obj.ExceptionInfo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DbHelper obj = new DbHelper();
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Int32.TryParse(row.Cells["ID"].Value.ToString(), out ReportId);
                DataTable dt = obj.GetTable("select * from ReportMaster where Id=" + ReportId + " ");
                if (dt.Rows.Count > 0)
                {
                    txtReportName.Text = dt.Rows[0]["Name"].ToString();
                    btnSave.Text = "Update";
                    if (Convert.ToBoolean(dt.Rows[0]["HasTable"]))
                    {
                        rbtYes.Checked = true;
                    }
                    else
                    {
                        rbtNo.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            try
            {
                DbHelper dbHelper = new DbHelper();
                dataGridView1.DataSource = null;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.AllowUserToAddRows = false;
                DataTable dt = dbHelper.GetTable("select  *, '' as [IsTable] from ReportMaster where Name like '%" + txtReportName.Text + "%' order by Name");
                dataGridView1.DataSource = dt;                
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["HasTable"].Value))
                    {
                        row.Cells["IsTable"].Value = "Yes";
                    }
                    else
                    {
                        row.Cells["IsTable"].Value = "No";
                    }                                       
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
                DbHelper obj = new DbHelper();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["ChkDelete"].Value);
                    int id = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                    if (isChecked)
                    {
                        obj.NonQuery("delete from ReportMaster where Id=" + id + "");
                    }
                }
                BindGrid();
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells["SNO"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
