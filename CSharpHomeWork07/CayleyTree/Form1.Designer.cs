namespace CayleyTree
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
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblRightLength = new System.Windows.Forms.Label();
            this.lblLeftLength = new System.Windows.Forms.Label();
            this.lblRightAngle = new System.Windows.Forms.Label();
            this.lblLeftAngle = new System.Windows.Forms.Label();
            this.lblPenColor = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.panelCayleyTree = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.cBoxPenColor = new System.Windows.Forms.ComboBox();
            this.txtLeftTh = new System.Windows.Forms.TextBox();
            this.txtRightTh = new System.Windows.Forms.TextBox();
            this.txtLeftPer = new System.Windows.Forms.TextBox();
            this.txtRightPer = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Location = new System.Drawing.Point(41, 37);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(67, 15);
            this.lblDepth.TabIndex = 1;
            this.lblDepth.Text = "递归深度";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(41, 84);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(67, 15);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "主干长度";
            // 
            // lblRightLength
            // 
            this.lblRightLength.AutoSize = true;
            this.lblRightLength.Location = new System.Drawing.Point(41, 132);
            this.lblRightLength.Name = "lblRightLength";
            this.lblRightLength.Size = new System.Drawing.Size(97, 15);
            this.lblRightLength.TabIndex = 3;
            this.lblRightLength.Text = "右分支长度比";
            // 
            // lblLeftLength
            // 
            this.lblLeftLength.AutoSize = true;
            this.lblLeftLength.Location = new System.Drawing.Point(41, 185);
            this.lblLeftLength.Name = "lblLeftLength";
            this.lblLeftLength.Size = new System.Drawing.Size(97, 15);
            this.lblLeftLength.TabIndex = 4;
            this.lblLeftLength.Text = "左分支长度比";
            // 
            // lblRightAngle
            // 
            this.lblRightAngle.AutoSize = true;
            this.lblRightAngle.Location = new System.Drawing.Point(41, 248);
            this.lblRightAngle.Name = "lblRightAngle";
            this.lblRightAngle.Size = new System.Drawing.Size(82, 15);
            this.lblRightAngle.TabIndex = 5;
            this.lblRightAngle.Text = "右分支角度";
            // 
            // lblLeftAngle
            // 
            this.lblLeftAngle.AutoSize = true;
            this.lblLeftAngle.Location = new System.Drawing.Point(41, 310);
            this.lblLeftAngle.Name = "lblLeftAngle";
            this.lblLeftAngle.Size = new System.Drawing.Size(82, 15);
            this.lblLeftAngle.TabIndex = 6;
            this.lblLeftAngle.Text = "左分支角度";
            // 
            // lblPenColor
            // 
            this.lblPenColor.AutoSize = true;
            this.lblPenColor.Location = new System.Drawing.Point(41, 362);
            this.lblPenColor.Name = "lblPenColor";
            this.lblPenColor.Size = new System.Drawing.Size(67, 15);
            this.lblPenColor.TabIndex = 7;
            this.lblPenColor.Text = "画笔颜色";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(202, 419);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 8;
            this.btnDraw.Text = "draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // panelCayleyTree
            // 
            this.panelCayleyTree.AutoSize = true;
            this.panelCayleyTree.BackColor = System.Drawing.Color.White;
            this.panelCayleyTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCayleyTree.Location = new System.Drawing.Point(0, 0);
            this.panelCayleyTree.Name = "panelCayleyTree";
            this.panelCayleyTree.Size = new System.Drawing.Size(361, 474);
            this.panelCayleyTree.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.Controls.Add(this.cBoxPenColor);
            this.panel.Controls.Add(this.txtLeftTh);
            this.panel.Controls.Add(this.txtRightTh);
            this.panel.Controls.Add(this.txtLeftPer);
            this.panel.Controls.Add(this.txtRightPer);
            this.panel.Controls.Add(this.txtLength);
            this.panel.Controls.Add(this.txtDepth);
            this.panel.Controls.Add(this.btnDraw);
            this.panel.Controls.Add(this.lblPenColor);
            this.panel.Controls.Add(this.lblLeftAngle);
            this.panel.Controls.Add(this.lblRightAngle);
            this.panel.Controls.Add(this.lblLeftLength);
            this.panel.Controls.Add(this.lblRightLength);
            this.panel.Controls.Add(this.lblLength);
            this.panel.Controls.Add(this.lblDepth);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(318, 474);
            this.panel.TabIndex = 9;
            // 
            // cBoxPenColor
            // 
            this.cBoxPenColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPenColor.FormattingEnabled = true;
            this.cBoxPenColor.Items.AddRange(new object[] {
            "红色",
            "绿色",
            "蓝色"});
            this.cBoxPenColor.Location = new System.Drawing.Point(187, 359);
            this.cBoxPenColor.Name = "cBoxPenColor";
            this.cBoxPenColor.Size = new System.Drawing.Size(100, 23);
            this.cBoxPenColor.TabIndex = 15;
            // 
            // txtLeftTh
            // 
            this.txtLeftTh.Location = new System.Drawing.Point(187, 307);
            this.txtLeftTh.Name = "txtLeftTh";
            this.txtLeftTh.Size = new System.Drawing.Size(100, 25);
            this.txtLeftTh.TabIndex = 14;
            // 
            // txtRightTh
            // 
            this.txtRightTh.Location = new System.Drawing.Point(187, 245);
            this.txtRightTh.Name = "txtRightTh";
            this.txtRightTh.Size = new System.Drawing.Size(100, 25);
            this.txtRightTh.TabIndex = 13;
            // 
            // txtLeftPer
            // 
            this.txtLeftPer.Location = new System.Drawing.Point(187, 182);
            this.txtLeftPer.Name = "txtLeftPer";
            this.txtLeftPer.Size = new System.Drawing.Size(100, 25);
            this.txtLeftPer.TabIndex = 12;
            // 
            // txtRightPer
            // 
            this.txtRightPer.Location = new System.Drawing.Point(187, 129);
            this.txtRightPer.Name = "txtRightPer";
            this.txtRightPer.Size = new System.Drawing.Size(100, 25);
            this.txtRightPer.TabIndex = 11;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(187, 81);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 25);
            this.txtLength.TabIndex = 10;
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(187, 27);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(100, 25);
            this.txtDepth.TabIndex = 9;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelCayleyTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel);
            this.splitContainer1.Size = new System.Drawing.Size(683, 474);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 474);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblRightLength;
        private System.Windows.Forms.Label lblLeftLength;
        private System.Windows.Forms.Label lblRightAngle;
        private System.Windows.Forms.Label lblLeftAngle;
        private System.Windows.Forms.Label lblPenColor;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Panel panelCayleyTree;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtLeftTh;
        private System.Windows.Forms.TextBox txtRightTh;
        private System.Windows.Forms.TextBox txtLeftPer;
        private System.Windows.Forms.TextBox txtRightPer;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.ComboBox cBoxPenColor;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

