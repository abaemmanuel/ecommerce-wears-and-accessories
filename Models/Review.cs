namespace ECommerce.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Description { get; set; }
        public int Rate { get; set; }
    }
}
