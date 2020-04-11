using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMSWinForm
{
    public partial class Form1 : Form
    {
        // 测试用例
        OrderItem apple = new OrderItem(1, "apple", 10.0, 80);
        OrderItem egg = new OrderItem(2, "eggs", 1.2, 200);
        OrderItem milk = new OrderItem(3, "milk", 50, 10);
        OrderService orderService = new OrderService();

        // 查询条件和关键字
        public string SelectCondition { get; set; }
        public string KeyWord { get; set; }

        public Form1()
        {
            InitializeComponent();

            Order order1 = new Order(1, "Customer1", new List<OrderItem> { apple, egg, milk });
            Order order2 = new Order(2, "Customer2", new List<OrderItem> { egg, milk });
            Order order3 = new Order(3, "Customer2", new List<OrderItem> { apple, milk });
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);

            // 数据绑定
            orderBindingSource.DataSource = orderService.Orders;
            cbxSelectCodition.DataBindings.Add("Text", this, "SelectCondition");
            txtSelectCondition.DataBindings.Add("Text", this, "KeyWord");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            switch (SelectCondition)
            {
                case "订单号":
                    try
                    {
                        uint orderId = uint.Parse(KeyWord);
                        orderBindingSource.DataSource = orderService.QueryOrdersByOrderId(orderId);
                    }
                    catch
                    {
                        MessageBox.Show("Select condition is invalid!");
                    }
                    break;
                case "商品名称":
                    orderBindingSource.DataSource = orderService.QueryOrdersByGoodsName(KeyWord);
                    break;
                case "客户":
                    orderBindingSource.DataSource = orderService.QueryOrdersByCustomerName(KeyWord);
                    break;
                default:
                    orderBindingSource.DataSource = orderService.Orders;
                    break;
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("添加订单", null, orderService);
            form2.ShowDialog();
            orderBindingSource.ResetBindings(false);
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("修改订单",
                 (Order)orderBindingSource.Current, orderService);
            form2.ShowDialog();
            orderBindingSource.ResetBindings(false);
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            // 获取 OrderId
            uint orderId = ((Order)orderBindingSource.Current).OrderId;

            orderService.RemoveOrder(orderId);
            orderBindingSource.ResetBindings(false);

            MessageBox.Show("删除订单成功！");
        }

        private void btnExportOrder_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                orderService.Export(path);
                MessageBox.Show("导出订单成功！");
            }
        }
        
        private void btnImportOrder_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                orderService.Import(path);
                orderBindingSource.ResetBindings(false);
                MessageBox.Show("导入订单成功！");
            }
        }
    }
}
