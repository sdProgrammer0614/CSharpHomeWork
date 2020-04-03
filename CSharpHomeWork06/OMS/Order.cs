using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS
{
    [Serializable]
    public class Order : IComparable
    {
        public string Ordered { get; set; }         // 订单号
        public Customer Customer { get; set; }      // 客户
        public double totalPrice = 0.0;             // 订单总金额
        public List<OrderItem> orderItems = new List<OrderItem>();

        public Order(string Ordered, Customer Customer)
        {
            this.Ordered = Ordered;
            this.Customer = Customer;
        }

        public Order()
        {

        }

        public void AddItem(OrderItem orderItem)    // 添加订单项
        {
            if(orderItems.Contains(orderItem))
                throw new ApplicationException("This orderItem is already exist.");

            this.orderItems.Add(orderItem);
            totalPrice += orderItem.Quantity * orderItem.Product.Price;
        }

        public override string ToString()
        {
            string items = "";
            foreach (OrderItem item in orderItems)
            {
                items += item + "\n";
            }

            return $"Ordered: {Ordered}\n{Customer}\n{items}TotalPrice: {totalPrice}";
        }

        public int CompareTo(object obj)
        {
            Order order = obj as Order;
            if (order == null)
                throw new System.ArgumentException();
            return this.Ordered.CompareTo(order.Ordered);
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                   Ordered == order.Ordered;
        }

        public override int GetHashCode()
        {
            return -987424538 + EqualityComparer<string>.Default.GetHashCode(Ordered);
        }
    }
}
