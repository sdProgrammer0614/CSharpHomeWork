using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{

    /**
     **/
    public class OrderItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderItemId { get; set; }
        public int Index { get; set; }

        public Goods GoodsItem { get; set; }

        public string GoodsName { get => GoodsItem != null ? this.GoodsItem.Name : ""; }

        public double UnitPrice { get => GoodsItem != null ? this.GoodsItem.Price : 0.0; }
        
        public int Quantity { get; set; }

        public int OrderId { get; set; }

        public OrderItem() { }

        public OrderItem(int index, Goods goods, int quantity)
        {
            this.Index = index;
            this.GoodsItem = goods;
            this.Quantity = quantity;
        }

        public double TotalPrice
        {
            get => GoodsItem == null ? 0.0 : GoodsItem.Price * Quantity;
        }

        public override string ToString()
        {
            return $"[No.:{Index},goods:{GoodsName},quantity:{Quantity},totalPrice:{TotalPrice}]";
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null &&
                   GoodsName == item.GoodsName;
        }

        public override int GetHashCode()
        {
            var hashCode = -2127770830;
            hashCode = hashCode * -1521134295 + Index.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodsName);
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }
    }
}
