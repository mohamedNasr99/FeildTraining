using System.ComponentModel.DataAnnotations;

namespace FeildTraining.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Name { get; set; }
        [Required]
        public string Phone { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public ICollection<Order>? Order { get; set; }
    }
}
