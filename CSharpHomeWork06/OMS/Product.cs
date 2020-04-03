using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS
{
    public class Product
    {
        public string Pid { set; get; }         // 货物识别码
        public double Price { set; get; }       // 货物单价

        public Product(string Pid, double Price)
        {
            this.Pid = Pid;
            this.Price = Price;
        }

        public Product()
        {

        }

        public override string ToString()
        {
            return $"Product: {Pid}, {Price}";
        }
    }
}
