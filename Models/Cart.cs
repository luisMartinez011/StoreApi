using StoreAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreAPI.Models
{
    public class Cart
    {
        public int CartId {  get; set; }
       
        public Guid UserId { get; set; }
        public User User { get; set; }
        public float TotalAmount { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;
        
        public ICollection<CartItem> CartItems { get; set; }
    }
}
