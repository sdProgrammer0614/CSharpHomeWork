using System;
using System.Collections.Generic;

namespace OrderManagementSystem
{
    public class Order : IComparable
    {
        public string Ordered { get; }          // 订单号
        public Customer Customer { get; }       // 客户
        public double totalPrice = 0.0;         // 订单总金额
        public List<OrderItem> orderItems = new List<OrderItem>();

        public Order(string Ordered, Customer Customer)
        {
            this.Ordered = Ordered;
            this.Customer = Customer;
        }

        public void AddItem(OrderItem orderItem)    // 添加订单项
        {
            foreach (OrderItem item in orderItems)
            {
                if (orderItem.Equals(item))
                {
                    Console.WriteLine("订单项重复");
                    return;
                }
            }

            this.orderItems.Add(orderItem);
            totalPrice += orderItem.Quantity * orderItem.Product.Price;
        }

        public override string ToString()
        {
            foreach (OrderItem item in orderItems)
            {
                Console.WriteLine(item);
            }

            return $"Ordered: {Ordered}, Customer: {Customer}, totalPrice: {totalPrice}\n";
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
