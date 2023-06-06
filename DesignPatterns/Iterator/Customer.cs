namespace DesignPatterns.Iterator
{
    public class Customer
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public CustomerType CustomerType { get; set; }
    }
    public enum CustomerType
    {
        REGULAR,
        PREMIUM
    }
}