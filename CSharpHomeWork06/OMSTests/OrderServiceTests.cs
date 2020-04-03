using Microsoft.VisualStudio.TestTools.UnitTesting;
using OMS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OMS.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        Customer customer01 = new Customer("customer01", "CS - 1");
        Customer customer02 = new Customer("customer02", "CS - 2");
        Customer customer03 = new Customer("customer03", "CS - 3");

        Product product01 = new Product("Product01", 10);
        Product product02 = new Product("Product02", 20);
        Product product03 = new Product("Product03", 30);

        OrderService orderService = new OrderService();

        [TestInitialize()]
        public void Initialize()
        {
            OrderItem orderItem01 = new OrderItem(product01, 2);
            OrderItem orderItem02 = new OrderItem(product02, 4);
            OrderItem orderItem03 = new OrderItem(product03, 6);

            Order order01 = new Order("001", customer01);
            Order order02 = new Order("002", customer01);
            Order order03 = new Order("003", customer01);

            order01.AddItem(orderItem01);
            order01.AddItem(orderItem02);
            order02.AddItem(orderItem01);
            order02.AddItem(orderItem03);
            order03.AddItem(orderItem02);
            order03.AddItem(orderItem03);

            orderService.AddOrder(order01);
            orderService.AddOrder(order02);
            orderService.AddOrder(order03);
        }

        [TestMethod()]
        public void AddOrderTest01()
        {
            Order order04 = new Order("004", customer01);
            orderService.AddOrder(order04);
            Assert.AreEqual(4, orderService.orders.Count());
        }

        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void AddOrderTest02()
        {
            Order order04 = new Order("003", customer01);
            orderService.AddOrder(order04);
        }

        [TestMethod()]
        public void DeleteOrderTest01()
        {
            Order order04 = new Order("003", customer01);
            orderService.DeleteOrder(order04);
            Assert.AreEqual(2, orderService.orders.Count());
        }

        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void DeleteOrderTest02()
        {
            Order order04 = new Order("004", customer01);
            orderService.DeleteOrder(order04);
        }

        [TestMethod()]
        public void UpdateOrderTest()
        {
            Order order04 = new Order("003", customer01);
            orderService.UpdateOrder(orderService.orders[2], order04);
            Assert.AreEqual(3, orderService.orders.Count());
            CollectionAssert.Contains(orderService.orders, order04);
        }

        [TestMethod()]
        public void SelectByPidTest()
        {
            List<Order> orders01 = orderService.SelectByPid("Product01");
            Assert.IsNotNull(orders01);
            List<Order> orders02 = orderService.SelectByPid("Product04");
            Assert.AreEqual(0, orders02.Count());
        }

        [TestMethod()]
        public void SelectByOrderTest()
        {
            List<Order> orders01 = orderService.SelectByOrder("001");
            Assert.IsNotNull(orders01);
            List<Order> orders02 = orderService.SelectByOrder("004");
            Assert.AreEqual(0, orders02.Count());
        }

        [TestMethod()]
        public void SelectByCustomerTest()
        {
            List<Order> orders01 = orderService.SelectByCustomer(customer01);
            Assert.IsNotNull(orders01);
            Customer customer04 = new Customer("customer04", "CS - 4");
            List<Order> orders02 = orderService.SelectByCustomer(customer04);
            Assert.AreEqual(0, orders02.Count());
        }

        [TestMethod()]
        public void ExportTest()
        {
            string path = "./newOrders.xml";
            orderService.Export();
            Assert.IsTrue(File.Exists("orders.xml"));

            string[] expectResult =  File.ReadAllLines(path);
            string[] result = File.ReadAllLines("./orders.xml");

            Assert.AreEqual(expectResult.Count(), result.Count());

            for(int i = 0; i < result.Count(); i++)
            {
                Assert.AreEqual(expectResult[i], result[i]);
            }
        }

        [TestMethod()]
        public void ImportTest1()
        {
            orderService.Import("./newOrders.xml");
            Assert.AreEqual(3, orderService.orders.Count);
        }

        [TestMethod()]
        [ExpectedException(typeof(FileNotFoundException))]
        public void ImportTest2()
        {
            orderService.Import("./newOrders111.xml");
            Assert.AreEqual(3, orderService.orders.Count);
        }
    }
}