using FastReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFApp
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            Load += Form1_Load;
            IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Report report = new Report();
            //designerControl1.Report = report;
            //designerControl1.RefreshLayout();
        }

        private void 模板编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTemplateFrm tf = new FTemplateFrm();
            tf.MdiParent = this;
            tf.Show();
        }

        private void 水平平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void 窗体层叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 鞋标签打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShoesLabelFrm slf = new ShoesLabelFrm();
            slf.MdiParent = this;
            slf.Show();
        }
    }
}
