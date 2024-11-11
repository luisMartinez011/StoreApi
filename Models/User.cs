using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace StoreAPI.Models
{
    public class User 
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid UserId { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        public virtual Cart Cart { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public Boolean IsConfirmed { get; set; } = false;


    }
}
