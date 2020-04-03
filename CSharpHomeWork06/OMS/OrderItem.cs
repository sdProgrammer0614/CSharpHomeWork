using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS
{
    public class OrderItem
    {
        public Product Product { set; get; }    // 订购产品
        public int Quantity { set; get; }       // 订购数量

        public OrderItem(Product Product, int Quantity)
        {
            this.Product = Product;
            this.Quantity = Quantity;
        }

        public OrderItem()
        {

        }

        public override string ToString()
        {
            return $"OrderItem\n{Product}, Quantity: {Quantity}";
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null &&
                   EqualityComparer<Product>.Default.Equals(Product, item.Product);
        }

        public override int GetHashCode()
        {
            var hashCode = -220041308;
            hashCode = hashCode * -1521134295 + EqualityComparer<Product>.Default.GetHashCode(Product);
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }
    }
}
