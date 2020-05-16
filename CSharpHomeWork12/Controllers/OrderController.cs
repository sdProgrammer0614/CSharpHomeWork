using System;
using System.Collections.Generic;
using System.Linq;
using OrderApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSharpHomeWork12.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderContext orderDb;

        public OrderController(OrderContext context)
        {
            this.orderDb = context;
        }

        // GET: api/order
        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            IQueryable<Order> query = orderDb.Orders;
            return query.Include(o => o.Customer).Include(o => o.Items).ThenInclude(item => item.GoodsItem).ToList();
        }

        // GET: api/order/{id}
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderById(string id)
        {
            var order = orderDb.Orders.Include(o => o.Customer).Include(o => o.Items).ThenInclude(item => item.GoodsItem)
                .FirstOrDefault(o => o.Id == id);

            if (order == null)
                return NotFound();
            
            return order;
        }

        // GET: api/order/{name}
        [HttpGet("{name}")]
        public ActionResult<List<Order>> GetOrderByCustomer(string customerName)
        {
            var orders = orderDb.Orders.Include(o => o.Customer).Include(o => o.Items).ThenInclude(item => item.GoodsItem)
                .Where(o => o.Customer.Name == customerName);

            if (orders == null)
                return NotFound();
            
            return orders.ToList();
        }

        // GET: api/order/{goods}
        [HttpGet("{goods}")]
        public ActionResult<List<Order>> GetOrderByGoods(string goodsName)
        {
            var orders = orderDb.Orders.Include(o => o.Customer).Include(o => o.Items).ThenInclude(item => item.GoodsItem)
                .Where(o => o.Items.Count(i => i.GoodsItem.Name == goodsName) > 0);

            if (orders == null)
                return NotFound();
            
            return orders.ToList();
        }

        // POST: api/order
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                order.CustomerId = order.Customer.ID;
                order.Customer = null;
                order.Items.ForEach(item => {
                    item.GoodsItemId = item.GoodsItem.ID;
                    item.GoodsItem = null;
                    item.OrderId = order.Id;
                });
                orderDb.Add(order);
                orderDb.SaveChanges();
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }

            return order;
        }

        // PUT: api/order/{id}
        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(string id, Order order)
        {
            if (id != order.Id)
                return BadRequest("Id cannot be modified!");
            
            try
            {
                var oldItems = orderDb.OrderItems.Where(item => item.OrderId == id);
                orderDb.OrderItems.RemoveRange(oldItems);
                orderDb.Entry(order).State = EntityState.Modified;
                orderDb.OrderItems.AddRange(order.Items);
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null)
                    error = e.InnerException.Message;
                
                return BadRequest(error);
            }

            return NoContent();
        }

        // DELETE: api/order/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(string id)
        {
            try
            {
                var order = orderDb.Orders.Include("Items").Where(o => o.Id == id).FirstOrDefault();
                if (order != null)
                {
                    orderDb.Remove(order);
                    orderDb.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }

            return NoContent();
        }
    }
}