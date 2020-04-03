using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS
{
    class Program
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer("Chen Hang", "WHU-CS");
            Product product = new Product("iPhone", 5500);
            OrderItem orderItem = new OrderItem(product, 1);
            Order order = new Order("001", customer);
            order.AddItem(orderItem);

            OrderService orderService = new OrderService();
            orderService.AddOrder(order);

            orderService.ShowOrders();

            orderService.Export();
            orderService.Import("./orders.xml");
            orderService.ShowOrders();
        }
    }
}
