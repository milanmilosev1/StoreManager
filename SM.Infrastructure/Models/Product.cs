namespace SM.Infrastructure.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public int Price { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
