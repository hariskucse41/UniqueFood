namespace UniqueFood.API.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; } = 1;

        // Navigation
        public Product? Product { get; set; }
        public User? User { get; set; }
    }
}
