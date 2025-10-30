namespace UniqueFood.API.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderNo { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int? PaymentId { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime OrderDate { get; set; } = DateTime.Now;

        // Navigation
        public User? User { get; set; }
        public Payment? Payment { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
