using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace PathLab
{
    public partial class frmReport : Form
    {
        public static int PatientReportId = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        public frmReport(int patientReportId)
        {
            try
            {
                InitializeComponent();
                PatientReportId = patientReportId;
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            try
            {
                DbHelper obj = new DbHelper();
                string patientQuery = "SELECT pm.PatientName, pm.Age, pm.Gender, dm.Title, dm.DoctorName,prm.CreatedDate FROM ((PatientReportMaster prm INNER JOIN                          PatientMaster pm ON prm.PatientId = pm.ID) INNER JOIN DoctorMaster dm ON pm.DoctorId = dm.ID) where prm.ID=" + PatientReportId + "";

                DataTable dt = obj.GetTable(patientQuery);
                if (dt.Rows.Count > 0)
                {
                    string query = "SELECT PatientMaster.PatientName, PatientMaster.Age, TestMaster.TestName, TestMaster.NormalValue, TestMaster.Unit, PatientTestReportValue.TestValue as [Value] FROM (PatientMaster INNER JOIN PatientReportMaster ON PatientMaster.ID = PatientReportMaster.PatientId) INNER JOIN (PatientTestReportValue INNER JOIN TestMaster ON PatientTestReportValue.TestID = TestMaster.ID) ON PatientReportMaster.ID = PatientTestReportValue.PatientReportID where PatientReportMaster.ID=" + PatientReportId + ";";
                    obj = new DbHelper();
                    DataTable dtReport = obj.GetTable(query);
                    string gender = "";
                    if (Convert.ToString(dt.Rows[0]["Gender"]) == "M")
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    reportViewer1.LocalReport.ReportEmbeddedResource = "PathLab.rptPatientReport.rdlc";
                    ReportDataSource rds = new ReportDataSource("dsReport", dtReport);
                    reportViewer1.LocalReport.DataSources.Clear();
                    ReportParameter prmPatientName = new ReportParameter("PatientName", Convert.ToString(dt.Rows[0]["PatientName"]));
                    ReportParameter prmAge = new ReportParameter("Age", Convert.ToString(dt.Rows[0]["Age"]));
                    ReportParameter prmDoctor = new ReportParameter("Doctor", Convert.ToString(dt.Rows[0]["DoctorName"]));
                    ReportParameter prmGender = new ReportParameter("Sex", Convert.ToString(dt.Rows[0]["Gender"]));
                    ReportParameter prmDate = new ReportParameter("Date", Convert.ToDateTime(dt.Rows[0]["CreatedDate"]).ToShortDateString());
                    reportViewer1.LocalReport.SetParameters(new ReportParameter[] { prmPatientName, prmAge, prmDoctor, prmGender, prmDate });

                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.LocalReport.Refresh();
                }
            }
            catch (Exception ex)
            {
                string message = "Message " + ex.Message + "InnerException " + ex.InnerException + " Source " + ex.Source + " Stack Trace " + ex.StackTrace;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.reportViewer1.RefreshReport();
            
        }

    }
}
