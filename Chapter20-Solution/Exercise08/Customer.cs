namespace Exercise08
{
    internal class Customer
    {
        public CustomerType Type { get; private set; }

    }

    public enum CustomerType
    {
        Individual,Company
    }
}