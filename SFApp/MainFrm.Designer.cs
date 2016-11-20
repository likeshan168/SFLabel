namespace SFApp
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.标签ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.鞋标签打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顺丰标签打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模板编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.水平平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗体层叠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.标签ToolStripMenuItem,
            this.模板ToolStripMenuItem,
            this.WindowToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 标签ToolStripMenuItem
            // 
            this.标签ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.鞋标签打印ToolStripMenuItem,
            this.顺丰标签打印ToolStripMenuItem});
            this.标签ToolStripMenuItem.Name = "标签ToolStripMenuItem";
            this.标签ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.标签ToolStripMenuItem.Text = "标签(&B)";
            // 
            // 鞋标签打印ToolStripMenuItem
            // 
            this.鞋标签打印ToolStripMenuItem.Name = "鞋标签打印ToolStripMenuItem";
            this.鞋标签打印ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.鞋标签打印ToolStripMenuItem.Text = "鞋标签打印(&X)";
            this.鞋标签打印ToolStripMenuItem.Click += new System.EventHandler(this.鞋标签打印ToolStripMenuItem_Click);
            // 
            // 顺丰标签打印ToolStripMenuItem
            // 
            this.顺丰标签打印ToolStripMenuItem.Name = "顺丰标签打印ToolStripMenuItem";
            this.顺丰标签打印ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.顺丰标签打印ToolStripMenuItem.Text = "顺丰标签打印(&S)";
            // 
            // 模板ToolStripMenuItem
            // 
            this.模板ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.模板编辑ToolStripMenuItem});
            this.模板ToolStripMenuItem.Name = "模板ToolStripMenuItem";
            this.模板ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.模板ToolStripMenuItem.Text = "模板(&T)";
            // 
            // 模板编辑ToolStripMenuItem
            // 
            this.模板编辑ToolStripMenuItem.Name = "模板编辑ToolStripMenuItem";
            this.模板编辑ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.模板编辑ToolStripMenuItem.Text = "模板编辑(&E)";
            this.模板编辑ToolStripMenuItem.Click += new System.EventHandler(this.模板编辑ToolStripMenuItem_Click);
            // 
            // WindowToolStrip
            // 
            this.WindowToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.水平平铺ToolStripMenuItem,
            this.垂直平铺ToolStripMenuItem,
            this.窗体层叠ToolStripMenuItem,
            this.退出EToolStripMenuItem});
            this.WindowToolStrip.Name = "WindowToolStrip";
            this.WindowToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.WindowToolStrip.Size = new System.Drawing.Size(60, 21);
            this.WindowToolStrip.Text = "窗口(&V)";
            // 
            // 水平平铺ToolStripMenuItem
            // 
            this.水平平铺ToolStripMenuItem.Name = "水平平铺ToolStripMenuItem";
            this.水平平铺ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.水平平铺ToolStripMenuItem.Text = "水平平铺(&H)";
            this.水平平铺ToolStripMenuItem.Click += new System.EventHandler(this.水平平铺ToolStripMenuItem_Click);
            // 
            // 垂直平铺ToolStripMenuItem
            // 
            this.垂直平铺ToolStripMenuItem.Name = "垂直平铺ToolStripMenuItem";
            this.垂直平铺ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.垂直平铺ToolStripMenuItem.Text = "垂直平铺(&V)";
            this.垂直平铺ToolStripMenuItem.Click += new System.EventHandler(this.垂直平铺ToolStripMenuItem_Click);
            // 
            // 窗体层叠ToolStripMenuItem
            // 
            this.窗体层叠ToolStripMenuItem.Name = "窗体层叠ToolStripMenuItem";
            this.窗体层叠ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.窗体层叠ToolStripMenuItem.Text = "窗体层叠(&C)";
            this.窗体层叠ToolStripMenuItem.Click += new System.EventHandler(this.窗体层叠ToolStripMenuItem_Click);
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            this.退出EToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.退出EToolStripMenuItem.Text = "退出(&E)";
            this.退出EToolStripMenuItem.Click += new System.EventHandler(this.退出EToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 483);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "标签打印";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 模板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 模板编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowToolStrip;
        private System.Windows.Forms.ToolStripMenuItem 水平平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗体层叠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 标签ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 鞋标签打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顺丰标签打印ToolStripMenuItem;
    }
}

