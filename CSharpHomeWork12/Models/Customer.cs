using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace OrderApi.Models
{
    public class Customer
    {
        [Key]
        public string ID { get; set; }

        public string Name { get; set; }

        public Customer()
        {
            ID = Guid.NewGuid().ToString();
        }

        public Customer(string name) : this()
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            return customer != null &&
                   ID == customer.ID &&
                   Name == customer.Name;
        }

        public override int GetHashCode()
        {
            var hashCode = 1479869798;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}