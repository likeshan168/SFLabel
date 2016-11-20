namespace SFApp
{
    partial class ShoesLabelFrm
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
            this.barCode = new System.Windows.Forms.TextBox();
            this.cbxTemplates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // barCode
            // 
            this.barCode.Location = new System.Drawing.Point(81, 39);
            this.barCode.Name = "barCode";
            this.barCode.Size = new System.Drawing.Size(207, 21);
            this.barCode.TabIndex = 0;
            this.barCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barCode_KeyDown);
            // 
            // cbxTemplates
            // 
            this.cbxTemplates.FormattingEnabled = true;
            this.cbxTemplates.Location = new System.Drawing.Point(367, 39);
            this.cbxTemplates.Name = "cbxTemplates";
            this.cbxTemplates.Size = new System.Drawing.Size(134, 20);
            this.cbxTemplates.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "条形码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "选择模板";
            // 
            // ShoesLabelFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTemplates);
            this.Controls.Add(this.barCode);
            this.Name = "ShoesLabelFrm";
            this.Text = "ShoesLabelFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox barCode;
        private System.Windows.Forms.ComboBox cbxTemplates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}