using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagementSystem
{
    class OrderService
    {
        public List<Order> orders = new List<Order>();

        public void ShowOrders()                // 展示订单
        {
            foreach(Order order in orders)
            {
                Console.WriteLine(order);
            }
        }

        public void AddOrder(Order order)       // 添加订单
        {
            foreach (Order od in orders)
            {
                if (order.Equals(od))
                {
                    Console.WriteLine("订单重复");
                    return;
                }
            }
            orders.Add(order);
        }

        public void DeleteOrder(Order order)    // 删除订单
        {
            foreach (Order od in orders)
            {
                if (order.Equals(od))
                {
                    orders.Remove(od);
                    return;
                }
            }

            Console.WriteLine("订单不存在！");
        }

        public void UpdateOrder(Order order, Order updateOrder)     // 更新订单
        {
            foreach (Order od in orders)
            {
                if (order.Equals(od))
                    orders[orders.IndexOf(order)] = updateOrder;
                return;
            }

            Console.WriteLine("订单不存在！");
        }

        // 查询
        public void SelectByOrder(string ordered)       // 订单号
        {
            var ods = from order in orders
                      where order.Ordered == ordered
                      orderby order.totalPrice
                      select order;

            List<Order> orderList = ods.ToList();

            if (orderList.Count() == 0)
                Console.WriteLine("订单不存在！");
            else
            {
                foreach (Order od in ods)
                {
                    Console.WriteLine(od);
                }
            }
        }

        public void SelectByPid(string Pid)         // 货物名称
        {
            foreach (Order order in orders)
            {
                var ods = from odItem in order.orderItems
                          where odItem.Product.Pid == Pid
                          select order;

                List<Order> orderList = ods.ToList();

                if (orderList.Count() == 0)
                    Console.WriteLine("订单不存在！");
                else
                {
                    foreach (Order od in ods)
                    {
                        Console.WriteLine(od);
                    }
                }
            }
        }

        public void SelectByCustomer(Customer customer)     // 客户
        {
            var ods = from order in orders
                      where order.Customer == customer
                      orderby order.totalPrice
                      select order;

            List<Order> orderList = ods.ToList();

            if (orderList.Count() == 0)
                Console.WriteLine("订单不存在！");
            else
            {
                foreach (Order od in ods)
                {
                    Console.WriteLine(od);
                }
            }
        }
    }
}
