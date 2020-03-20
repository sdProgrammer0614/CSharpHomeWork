namespace OrderManagementSystem
{
    public class Customer
    {
        public string Name { get; }             // 客户姓名
        public string Address { set; get; }     // 客户地址

        public Customer(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}";
        }
    }
}
