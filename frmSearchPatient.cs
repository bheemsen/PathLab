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
    public partial class frmSearchPatient : Form
    {
        public frmSearchPatient()
        {            
            InitializeComponent();
            FillGender();
            for (int i = 0; i < 100; i++)
            {
                ddlAge.Items.Add(i);
            }
            ddlAge.SelectedIndex = 0;
            FillDoctor();
            FillGrid();
        }

        protected void FillGender()
        {
            ddlGender.DataSource = clsGender.GetGender();
            ddlGender.ValueMember = "Value";
            ddlGender.DisplayMember = "Text";
        }

        protected void FillDoctor()
        {
            try
            {
                DbHelper obj = new DbHelper();
                DataTable dt = obj.GetTable("select * from DoctorMaster where IsDeleted=0");
                DataRow dr = dt.NewRow();
                dr["ID"] = 0;
                dr["DoctorName"] = "Select";
                dt.Rows.Add(dr);
                ddlDoctor.DataSource = dt;
                ddlDoctor.ValueMember = "ID";
                ddlDoctor.DisplayMember = "DoctorName";
                ddlDoctor.SelectedValue = 0;
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
                DbHelper obj = new DbHelper();
                string query = "insert into PatientMaster (PatientName, MobileNo, Age, Gender, DoctorId) values ('" + txtName.Text + "','" + txtMobile.Text + "'," + ddlAge.GetItemText(ddlAge.SelectedItem) + ",'" + ddlGender.SelectedValue + "','" + ddlDoctor.SelectedValue + "')";
                bool i = obj.NonQuery(query);
                if (i)
                {
                    FillGrid();
                    MessageBox.Show("Patient Added Successfully.........");
                }
                else
                {
                    MessageBox.Show("Error occurred." + obj.ExceptionInfo + "");
                }
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected void FillGrid()
        {
            try
            {
                gridPatient.AutoGenerateColumns = false;
                DbHelper obj = new DbHelper();
                string query = "select pm.*,'' as Sex, 0 as SNO, dm.DoctorName from PatientMaster pm inner join DoctorMaster dm on pm.DoctorId=dm.Id";
                DataTable dt = obj.GetTable(query);
                gridPatient.DataSource = dt;
                int i = 1;
                foreach (DataGridViewRow row in gridPatient.Rows)
                {
                    var gender = Convert.ToString(row.Cells["Gender"].Value);
                    if (gender == "M")
                    {
                        row.Cells["Sex"].Value = "Male";
                    }
                    else
                    {
                        row.Cells["Sex"].Value = "Female";
                    }
                    row.Cells["SNO"].Value = i;
                    i++;
                }
                gridPatient.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select pm.*,'' as Sex, 0 as SNO, dm.DoctorName from PatientMaster pm inner join DoctorMaster dm on pm.DoctorId=dm.Id where 1=1 ";
                if (!string.IsNullOrEmpty(txtMobile.Text))
                {
                    query += "";
                }
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    query += "";
                }
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridPatient_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = gridPatient.Rows[e.RowIndex];
                int patientId = 0;
                Int32.TryParse(row.Cells["ID"].Value.ToString(), out patientId);
                frmPatientReport objReport = new frmPatientReport(patientId);
                objReport.MdiParent = this.MdiParent;
                objReport.WindowState = FormWindowState.Maximized;
                objReport.Show();
                
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

}