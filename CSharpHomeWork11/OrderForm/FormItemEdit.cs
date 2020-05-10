using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace OrderForm
{
    public partial class FormItemEdit : Form
    {
        public OrderItem OrderItem { get; set; }

        public FormItemEdit()
        {
            InitializeComponent();
        }

        public FormItemEdit(OrderItem orderItem) : this()
        {
            this.OrderItem = orderItem;
            this.ItemBindingSource.DataSource = orderItem;

            using (var context = new OrderContext())
            {
                List<Goods> goods = context.Goods.ToList();
                goods.ForEach(g => goodsBindingSource.Add(g));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemBindingSource.ResetBindings(false);
        }
    }
}
