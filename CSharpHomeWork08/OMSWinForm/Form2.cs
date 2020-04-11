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
    public partial class Form2 : Form
    {
        public List<OrderItem> Items = new List<OrderItem>();
        public Order CurrentOrder { get; set; }
        public OrderService OrderService { get; set; }
        
        public string OrderId { get; set; }
        public string Customer { get; set; }

        public Form2(string title, Order currentOrder, OrderService orderService)
        {
            InitializeComponent();
            this.Text = title;
            this.CurrentOrder = currentOrder;
            this.OrderService = orderService;

            if (currentOrder != null)
            {
                this.OrderId = currentOrder.OrderId.ToString();
                this.Customer = currentOrder.Customer;
                this.itemsBindingSource.DataSource = currentOrder.Items;

                txtOrderId.Enabled = false;
            }
            else
            {
                this.itemsBindingSource.DataSource = Items;
            }

            txtOrderId.DataBindings.Add("Text", this, "OrderId");
            txtCustomer.DataBindings.Add("Text", this, "Customer");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentOrder != null)
                {
                    List<OrderItem> items = (List<OrderItem>)itemsBindingSource.DataSource;
                    Order order = new Order(CurrentOrder.OrderId, Customer, items);
                    CurrentOrder = order;
                    OrderService.UpdateOrder(CurrentOrder);
                    MessageBox.Show("修改成功！");
                }
                else
                {
                    List<OrderItem> items = (List<OrderItem>)itemsBindingSource.DataSource;
                    Order order = new Order(uint.Parse(OrderId), Customer, items);
                    CurrentOrder = order;
                    OrderService.AddOrder(CurrentOrder);
                    MessageBox.Show("修改成功！");
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("非法输入！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
