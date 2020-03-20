using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagementSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 测试
            Customer customer01 = new Customer("张三", "北京市");
            Customer customer02 = new Customer("李四", "湖北省");

            Product product01 = new Product("Eat", 1.5);
            Product product02 = new Product("Drink", 2.5);

            OrderItem orderItem01 = new OrderItem(product01, 2);
            OrderItem orderItem02 = new OrderItem(product02, 5);
            OrderItem orderItem03 = new OrderItem(product02, 2);

            Order order01 = new Order("订单1", customer01);
            Order order02 = new Order("订单2", customer02);

            // 订单添加订单项
            order01.AddItem(orderItem01);
            order01.AddItem(orderItem02);

            order02.AddItem(orderItem01);
            order02.AddItem(orderItem01);       // 订单项重复
            order02.AddItem(orderItem03);

            OrderService orderService = new OrderService();
            orderService.AddOrder(order01);
            orderService.AddOrder(order01);     // 订单重复
            orderService.AddOrder(order02);

            // 排序
            orderService.ShowOrders();
            orderService.orders.Sort();
            orderService.ShowOrders();

            // 更新订单
            orderService.UpdateOrder(order01, order02);
            orderService.ShowOrders();

            // 查询
            orderService.SelectByOrder("订单2");
            orderService.SelectByPid("Eat");
            orderService.SelectByCustomer(customer01);

            // 删除订单
            orderService.DeleteOrder(order02);
            orderService.ShowOrders();
        }
    }
}
