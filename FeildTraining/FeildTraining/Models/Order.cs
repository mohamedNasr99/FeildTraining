using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FeildTraining.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string Time { get; set; } = string.Empty;
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public ICollection<Vendor>? Vendor { get; set; }
    }
}
