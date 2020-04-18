namespace Spider
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnStartSpider = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listInfo = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(24, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(61, 15);
            this.label.TabIndex = 0;
            this.label.Text = "初始URL";
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(109, 26);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(229, 25);
            this.txtURL.TabIndex = 1;
            // 
            // btnStartSpider
            // 
            this.btnStartSpider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartSpider.Location = new System.Drawing.Point(372, 20);
            this.btnStartSpider.Name = "btnStartSpider";
            this.btnStartSpider.Size = new System.Drawing.Size(87, 33);
            this.btnStartSpider.TabIndex = 3;
            this.btnStartSpider.Text = "启动爬虫";
            this.btnStartSpider.UseVisualStyleBackColor = true;
            this.btnStartSpider.Click += new System.EventHandler(this.btnStartSpider_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.btnStartSpider);
            this.panel1.Controls.Add(this.txtURL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(482, 72);
            this.panel1.TabIndex = 4;
            // 
            // listInfo
            // 
            this.listInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listInfo.FormattingEnabled = true;
            this.listInfo.ItemHeight = 15;
            this.listInfo.Location = new System.Drawing.Point(10, 82);
            this.listInfo.Margin = new System.Windows.Forms.Padding(5);
            this.listInfo.Name = "listInfo";
            this.listInfo.Size = new System.Drawing.Size(482, 301);
            this.listInfo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 393);
            this.Controls.Add(this.listInfo);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(520, 440);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Spider";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnStartSpider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listInfo;
    }
}

