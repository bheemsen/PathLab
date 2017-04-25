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
    public partial class frmMDIParent : Form
    {
        private int childFormNumber = 0;

        public frmMDIParent()
        {            
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void reportMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportMaster objReport = new frmReportMaster();
            objReport.MdiParent = this;
            objReport.WindowState = FormWindowState.Maximized;
            objReport.Show();
        }

        private void reportBuilderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportConfiguration objReportConfiguration = new frmReportConfiguration();
            objReportConfiguration.MdiParent = this;
            objReportConfiguration.WindowState = FormWindowState.Maximized;
            objReportConfiguration.Show();
        }

        private void testMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestMaster objReportConfiguration = new frmTestMaster();
            objReportConfiguration.MdiParent = this;
            objReportConfiguration.WindowState = FormWindowState.Maximized;
            objReportConfiguration.Show();
        }

        private void patientMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientMaster objReportConfiguration = new frmPatientMaster();
            objReportConfiguration.MdiParent = this;
            objReportConfiguration.WindowState = FormWindowState.Maximized;
            objReportConfiguration.Show();
        }

        private void searchPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchPatient objReportConfiguration = new frmSearchPatient();
            objReportConfiguration.MdiParent = this;
            objReportConfiguration.WindowState = FormWindowState.Maximized;
            objReportConfiguration.Show();
        }

        private void doctorMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoctorMaster objReportConfiguration = new frmDoctorMaster();
            objReportConfiguration.MdiParent = this;
            objReportConfiguration.WindowState = FormWindowState.Maximized;
            objReportConfiguration.Show();
        }

        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewPatientReport objfrmViewPatientReport = new frmViewPatientReport();
            objfrmViewPatientReport.MdiParent = this;
            objfrmViewPatientReport.WindowState = FormWindowState.Maximized;
            objfrmViewPatientReport.Show();
        }
    }
}
