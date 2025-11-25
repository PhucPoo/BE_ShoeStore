using System.ComponentModel;

namespace ShoeStoreAPI.Models
{
    public class Shoe
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? ImageURL { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
