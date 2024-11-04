using System.ComponentModel.DataAnnotations;

namespace StoreAPI.Models
{
    public class Category
    {
        public int CategoryId {  get; set; }
        public string Title { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Product> Products { get; set; }
    }
}
