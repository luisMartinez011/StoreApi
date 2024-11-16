using System.ComponentModel.DataAnnotations;

namespace StoreAPI.Models
{
    public class CartItem
    {
        public int CartItemId {  get; set; }

        public int CartId { get; set; }
        public Cart Cart { get; set; }

        public int ProductId { get; set; }
        public Product Product{ get; set; }
        public int Quantity { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;
    }
}
