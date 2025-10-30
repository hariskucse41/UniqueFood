namespace UniqueFood.API.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }  // 1–5 stars
        public string? Comment { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public Product? Product { get; set; }
        public User? User { get; set; }
    }

}
