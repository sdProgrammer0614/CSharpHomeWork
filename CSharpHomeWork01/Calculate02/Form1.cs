using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Double.Parse(textNum1.Text);
                double num2 = Double.Parse(textNum2.Text);

                switch (cBoxOp.Text)
                {
                    case "+":
                        textResult.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        textResult.Text = (num1 - num2).ToString();
                        break;
                    case "*":
                        textResult.Text = (num1 * num2).ToString();
                        break;
                    case "/":
                        if (num2 == 0)
                            textResult.Text = "除0错误";
                        else
                            textResult.Text = (num1 / num2).ToString();
                        break;
                    default:
                        textResult.Text = "输入符号错误";
                        break;
                }
            }
            catch (FormatException)
            {
                textResult.Text = "输入内容不是数字";
            }
            catch (OverflowException)
            {
                textResult.Text = "溢出";
            }
        }
    }
}
