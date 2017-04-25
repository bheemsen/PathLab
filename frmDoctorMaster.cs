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
    public partial class frmDoctorMaster : Form
    {
        
        public bool IsUpdate = false;
        public int DoctorId = 0;

        public frmDoctorMaster()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsUpdate)
                {
                    UpdateDoctor();
                    this.IsUpdate = false;
                    this.DoctorId = 0;
                    btnSave.Text = "Save";
                }
                else
                {
                    AddDoctor();
                }
                txtDoctorName.Text = string.Empty;
                txtTitle.Text = string.Empty;
                FillDoctor();
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
         
        private void frmDoctorMaster_Load(object sender, EventArgs e)
        {
            FillDoctor();
        }

        private void FillDoctor()
        {
            try
            {
                DbHelper obj = new DbHelper();
                DataTable dt = obj.GetTable("select  * from DoctorMaster where IsDeleted=0");
                gridDoctor.AutoGenerateColumns = false;
                if (dt.Rows.Count > 0)
                {
                    gridDoctor.DataSource = dt;
                    gridDoctor.Visible = true;
                    int i = 1;
                    foreach (DataGridViewRow row in gridDoctor.Rows)
                    {
                        row.Cells["SNO"].Value = i;
                        i++;
                    }
                }
                else
                {
                    gridDoctor.Visible = false;
                }

            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddDoctor()
        {
            DbHelper obj = new DbHelper();
            try
            {
                bool i = obj.NonQuery("insert into DoctorMaster ([Title], [DoctorName] ) values ('" + txtTitle.Text + "', '" + txtDoctorName.Text + "')");
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateDoctor()
        {
            try
            {
                DbHelper obj = new DbHelper();
                obj.NonQuery("update DoctorMaster set Title='" + txtTitle.Text + "', DoctorName='" + txtDoctorName.Text + "', DateUpDated='" + DateTime.Now + "' where ID=" + this.DoctorId + "  ");
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridDoctor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.IsUpdate = true;
                btnSave.Text = "Save Changes";
                txtTitle.Text = gridDoctor.SelectedRows[0].Cells["Title"].Value.ToString();
                txtDoctorName.Text = gridDoctor.SelectedRows[0].Cells["DoctorName"].Value.ToString();
                this.DoctorId = Convert.ToInt32(gridDoctor.SelectedRows[0].Cells["ID"].Value);
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
                obj.NonQuery("update DoctorMaster set IsDeleted=1, DateDeleted='" + DateTime.Now + "' where ID=" + this.DoctorId + "");
                txtDoctorName.Text = string.Empty;
                txtTitle.Text = string.Empty;
                FillDoctor();
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridDoctor_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void gridDoctor_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.gridDoctor.Rows[e.RowIndex].Cells["SNO"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
