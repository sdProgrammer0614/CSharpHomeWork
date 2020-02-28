namespace Calculate02
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
            this.labelNum1 = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.labelOp = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.cBoxOp = new System.Windows.Forms.ComboBox();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Location = new System.Drawing.Point(228, 108);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(95, 15);
            this.labelNum1.TabIndex = 0;
            this.labelNum1.Text = "firstNumber";
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Location = new System.Drawing.Point(228, 174);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(103, 15);
            this.labelNum2.TabIndex = 1;
            this.labelNum2.Text = "secondNumber";
            // 
            // labelOp
            // 
            this.labelOp.AutoSize = true;
            this.labelOp.Location = new System.Drawing.Point(228, 243);
            this.labelOp.Name = "labelOp";
            this.labelOp.Size = new System.Drawing.Size(71, 15);
            this.labelOp.TabIndex = 2;
            this.labelOp.Text = "operator";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(228, 317);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(55, 15);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "result";
            // 
            // cBoxOp
            // 
            this.cBoxOp.FormattingEnabled = true;
            this.cBoxOp.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cBoxOp.Location = new System.Drawing.Point(392, 243);
            this.cBoxOp.Name = "cBoxOp";
            this.cBoxOp.Size = new System.Drawing.Size(100, 23);
            this.cBoxOp.TabIndex = 4;
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(392, 108);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(100, 25);
            this.textNum1.TabIndex = 5;
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(392, 171);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(100, 25);
            this.textNum2.TabIndex = 6;
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(392, 317);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(147, 25);
            this.textResult.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(635, 355);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(99, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.cBoxOp);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelOp);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.labelNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.Label labelOp;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ComboBox cBoxOp;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button btnCalculate;
    }
}

