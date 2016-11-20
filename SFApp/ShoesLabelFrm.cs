using FastReport;
using FastReport.Preview;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SFApp.Bussiness;
using FastReport.Data;

namespace SFApp
{
    public partial class ShoesLabelFrm : Form
    {
        private Report report;
        public ShoesLabelFrm()
        {
            InitializeComponent();
            LoadTemplates();
            report = new Report();
        }



        private void barCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(barCode.Text))
                {
                    report.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, cbxTemplates.SelectedValue.ToString()));
                    PictureObject pic = (PictureObject)report.FindObject("Picture2");
                    report.SetParameterValue("BarCode", barCode.Text);
                    report.Show();
                }
            }
        }

        private void LoadTemplates()
        {
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            IList<string> files = di.GetFiles().Where(f => Path.GetExtension(f.Name) == ".frx").Select(f => f.Name).ToList();
            cbxTemplates.DataSource = files;
        }
    }
}
