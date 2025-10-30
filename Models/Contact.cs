namespace UniqueFood.API.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
