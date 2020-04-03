using System;
using System.Drawing;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        // 递归深度n，主干长度leng，右分支长度比per1，左分支长度比per2
        // 右分支角度th1，左分支角度th2，画笔颜色pen

        private Graphics graphics;
        int n;
        double leng;
        double per1;
        double per2;
        double th1;
        double th2;
        int pen;

        // 画笔颜色数组
        Pen[] penColor = { Pens.Red, Pens.Green, Pens.Blue };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                n = Int32.Parse(txtDepth.Text);
                leng = Double.Parse(txtLength.Text);
                per1 = Double.Parse(txtRightPer.Text);
                per2 = Double.Parse(txtLeftPer.Text);
                th1 = Double.Parse(txtRightTh.Text) * Math.PI / 180;
                th2 = Double.Parse(txtLeftTh.Text) * Math.PI / 180;
                pen = cBoxPenColor.SelectedIndex;

                if (graphics == null)
                    graphics = panelCayleyTree.CreateGraphics();
                else
                    graphics.Clear(Color.White);

                if (per1 > 0 && per1 < 1 && per2 > 0 && per2 < 1
                    && th1 > 0 && th1 < 90 && th2 > 0 && th2 < 90)
                    DrawCayleyTree(n, panelCayleyTree.Width / 2, panelCayleyTree.Height / 2 + 100,
                        leng, -Math.PI / 2);
                else
                    MessageBox.Show("长度比或角度不合理！");
            }
            catch
            {
                MessageBox.Show("输入异常！");
            }
        }

        void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0)
                return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void DrawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(penColor[pen], (int)x0, (int)y0, (int)x1, (int)y1);
        }
    }
}
