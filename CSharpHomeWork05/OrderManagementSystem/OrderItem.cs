using System.Collections.Generic;

namespace OrderManagementSystem
{
    public class OrderItem
    {
        public Product Product { get; }     // 订购产品
        public int Quantity { get; set; }   // 订购数量

        public OrderItem(Product Product, int Quantity)
        {
            this.Product = Product;
            this.Quantity = Quantity;
        }

        public override string ToString()
        {
            return $"Product: {Product}, Quantity: {Quantity}";
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
