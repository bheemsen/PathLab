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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DbHelper obj = new DbHelper();
            DataTable dt = obj.GetTable("select * from PatientReportMaster");
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReport obj = new frmReport(Convert.ToInt32(comboBox1.SelectedValue));
            obj.Show();
        }
    }
}
