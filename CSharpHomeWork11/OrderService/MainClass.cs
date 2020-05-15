using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    class MainClass
    {
        public static void Main()
        {
            try
            {
                //OrderItem apple = new OrderItem(1, "apple",10.0, 80);
                //OrderItem egg = new OrderItem(2, "eggs",1.2, 200);
                //OrderItem milk = new OrderItem(3, "milk",50, 10);

                //Order order1 = new Order(1, "Customer1", new List<OrderItem> { apple, egg, milk });
                //Order order2 = new Order(2, "Customer2", new List<OrderItem> { egg, milk });
                //Order order3 = new Order(3, "Customer2", new List<OrderItem> { apple, milk });

                //OrderService os = new OrderService();
                //os.AddOrder(order1);
                //os.AddOrder(order2);
                //os.AddOrder(order3);
                //os.Export(@"./orders.xml");

                //Console.WriteLine("GetAllOrders");
                //List<Order> orders = os.Orders;
                //orders.ForEach(o => Console.WriteLine(o));
                //Console.WriteLine("");

                //os.Sort((o1, o2) => o1.TotalPrice.CompareTo(o2.TotalPrice));
                //Console.WriteLine("GetAllOrders After sort");
                //orders = os.Orders;
                //orders.ForEach(o => Console.WriteLine(o));
                //Console.WriteLine("");

                //Console.WriteLine("GetOrdersByCustomerName:'Customer2'");
                //orders = os.QueryOrdersByCustomerName("Customer2");
                //orders.ForEach(o => Console.WriteLine(o));
                //Console.WriteLine("");

                //Console.WriteLine("GetOrdersByGoodsName:'apple'");
                //orders = os.QueryOrdersByGoodsName("apple");
                //orders.ForEach(o => Console.WriteLine(o));
                //Console.WriteLine("");

                //Console.WriteLine("Remove order(id=2) and qurey all");
                //os.RemoveOrder(2);
                //orders.ForEach(o => Console.WriteLine(o));
                //Console.WriteLine("");

                //Console.WriteLine("Import from ./orders.xml");
                //OrderService os2 = new OrderService();
                //os2.Import("./orders.xml");
                //os2.Orders.ForEach(order => Console.WriteLine(order));
                using (var db = new OrderContext())
                {
                    var order = db.OrderItems.FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
