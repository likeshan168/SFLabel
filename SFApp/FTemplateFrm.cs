using FastReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport.Utils;
using FastReport.Design;

namespace SFApp
{
    public partial class FTemplateFrm : Form
    {
        private Report report;
        public FTemplateFrm()
        {
            InitializeComponent();
            Load += FTemplateFrm_Load;
        }

        private void FTemplateFrm_Load(object sender, EventArgs e)
        {
            LoadTemplates();
            report = new Report();
            designerControl1.Report = report;
            designerControl1.RefreshLayout();
        }
        /// <summary>
        /// 加载本地所有的模板
        /// </summary>
        private void LoadTemplates()
        {
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            IEnumerable<FileInfo> files = di.GetFiles().Where(f => Path.GetExtension(f.Name) == ".frx");
            List<string> names = new List<string>();
            foreach (FileInfo file in files)
            {
                names.Add(file.Name);
            }
            listBox1.DataSource = names;
        }

        /// <summary>
        /// 自定义报表事件
        /// </summary>
        private void WireupDesignerEvents()
        {
            //Config.DesignerSettings.CustomOpenDialog += new OpenSaveDialogEventHandler(DesignerSettings_CustomOpenDialog);
            //Config.DesignerSettings.CustomOpenReport += new OpenSaveReportEventHandler(DesignerSettings_CustomOpenReport);
            //Config.DesignerSettings.CustomSaveDialog += new OpenSaveDialogEventHandler(DesignerSettings_CustomSaveDialog);
            //Config.DesignerSettings.CustomSaveReport += new OpenSaveReportEventHandler(DesignerSettings_CustomSaveReport);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(listBox1.SelectedValue.ToString());

            try
            {
                string selectedTemplateName = listBox1.SelectedValue.ToString();
                string selectedTemplateFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, selectedTemplateName);
                designerControl1.cmdOpen.LoadFile(selectedTemplateFilePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DesignerSettings_CustomOpenReport(object sender, OpenSaveReportEventArgs e)
        {
            //report?.Load(selectedTemplateFilePath);
        }
    }
}
