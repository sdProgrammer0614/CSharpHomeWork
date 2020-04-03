using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OMS
{
    public class OrderService
    {
        public List<Order> orders = new List<Order>();

        public void ShowOrders()                // 展示订单
        {
            foreach (Order order in orders)
            {
                Console.WriteLine(order);
            }
        }

        public void AddOrder(Order order)       // 添加订单
        {
            if (orders.Contains(order))
                throw new ApplicationException("This order is already exist.");

            orders.Add(order);
        }

        public void DeleteOrder(Order order)    // 删除订单
        {
            if (orders.Contains(order))
                orders.Remove(order);
            else
                throw new ApplicationException("This order isn't exist.");
        }

        public void UpdateOrder(Order order, Order updateOrder)     // 更新订单
        {
            if (orders.Contains(order))
                orders[orders.IndexOf(order)] = updateOrder;
            else
                throw new ApplicationException("This order isn't exist.");
        }

        // 查询
        public List<Order> SelectByOrder(string ordered)       // 订单号
        {
            var ods = from order in orders
                      where order.Ordered == ordered
                      orderby order.totalPrice
                      select order;

            List<Order> orderList = ods.ToList();

            return orderList;
        }

        public List<Order> SelectByPid(string Pid)         // 货物名称
        {
            var query = orders
                .Where(order => order.orderItems.Exists(item => item.Product.Pid == Pid))
                .OrderBy(o => o.totalPrice);
            return query.ToList();
        }

        public List<Order> SelectByCustomer(Customer customer)     // 客户
        {
            var ods = from order in orders
                      where order.Customer == customer
                      orderby order.totalPrice
                      select order;

            List<Order> orderList = ods.ToList();

            return orderList;
        }

        public void Sort()
        {
            this.orders.Sort();
        }

        public void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("orders.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> tempOrder = (List<Order>)xmlSerializer.Deserialize(fs);

                tempOrder.ForEach(order =>
                {
                    if (!orders.Contains(order))
                        orders.Add(order);
                });
            }
        }
    }
}
