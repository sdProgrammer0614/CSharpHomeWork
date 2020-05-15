using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp
{
    public class OrderService
    {
        //the order list
        private List<Order> orders;


        public OrderService()
        {
            orders = new List<Order>();
        }

        public List<Order> Orders
        {
            get => orders;
        }

        public Order GetOrder(string id)
        {
            using(var context = new OrderContext())
            {
                List<Customer> customers = context.Customers.ToList();
                List<Goods> goods = context.Goods.ToList();
                List<OrderItem> orderItems = context.OrderItems.ToList();

                var result = context.Orders.FirstOrDefault(o => o.Id == id);
                return result ?? null;
            }
        }

        public void AddOrder(Order order)
        {
            using (var context = new OrderContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        public void RemoveOrder(string orderId)
        {
            using (var context = new OrderContext())
            {
                Order order = context.Orders.Include("Items").FirstOrDefault(o => o.Id == orderId);
                if (order != null)
                {
                    this.orders.Remove(order);
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            }
        }

        public List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            using (var context = new OrderContext())
            {
                List<Customer> customers = context.Customers.ToList();
                List<Goods> goods = context.Goods.ToList();
                List<Order> orders = context.Orders.ToList();
                List<OrderItem> orderItems = context.OrderItems.ToList();

                var result = orders.Where(
                    order => order.Items.Exists(item => item.GoodsName == goodsName));

                return result.ToList();
            }
        }

        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            using (var context = new OrderContext())
            {
                List<Customer> customers = context.Customers.ToList();
                List<Goods> goods = context.Goods.ToList();
                List<OrderItem> orderItems = context.OrderItems.ToList();

                var result = context.Orders
                    .Where(o => o.Customer.Name == customerName);

                return result.ToList();
            }
        }

        public void UpdateOrder(Order newOrder)
        {
            using (var context = new OrderContext())
            {
                List<Customer> customers = context.Customers.ToList();
                List<Goods> goods = context.Goods.ToList();
                List<Order> orders = context.Orders.ToList();
                List<OrderItem> orderItems = context.OrderItems.ToList();

                Order oldOrder = context.Orders.FirstOrDefault(o => o.Id == newOrder.Id);
                if (oldOrder == null)
                    throw new ApplicationException($"修改错误：订单 {newOrder.Id} 不存在!");
                orders.Remove(oldOrder);
                orders.Add(newOrder);

                for (int i = 0; i < orderItems.Count(); i++)
                {
                    if (orderItems[i].OrderId == newOrder.Id)
                    {
                        context.OrderItems.Remove(orderItems[i]);
                    }
                }

                context.Orders.Remove(oldOrder);
                context.Orders.Add(newOrder);
                //context.SaveChanges();
            }
        }

        public void Sort()
        {
            orders.Sort();
        }

        public void Sort(Func<Order, Order, int> func)
        {
            Orders.Sort((o1, o2) => func(o1, o2));
        }

        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, Orders);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);

                using(var context = new OrderContext())
                {
                    temp.ForEach(order =>
                    {
                        if (!orders.Contains(order))
                        {
                            orders.Add(order);
                            context.Orders.Add(order);
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
