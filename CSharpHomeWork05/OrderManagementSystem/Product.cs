namespace OrderManagementSystem
{
    public class Product
    {
        public string Pid { get; }             // 货物识别码
        public double Price { set; get; }      // 货物单价

        public Product(string Pid, double Price)
        {
            this.Pid = Pid;
            this.Price = Price;
        }

        public override string ToString()
        {
            return $"Pid: {Pid}, Price: {Price}";
        }
    }
}
