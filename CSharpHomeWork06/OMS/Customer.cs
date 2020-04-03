using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS
{
    public class Customer
    {
        public string Name { set; get; }        // 客户姓名
        public string Address { set; get; }     // 客户地址

        public Customer(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        public Customer()
        {

        }

        public override string ToString()
        {
            return $"Customer: {Name}, {Address}";
        }
    }
}
