using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StoreAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public double Price { get; set; }
        [Required]
        public ICollection<CartItem> CartItems { get; set; }
        
        public string Img {  get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;
    }
}
