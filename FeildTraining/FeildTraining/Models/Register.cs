using System.ComponentModel.DataAnnotations;

namespace FeildTraining.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; }= string.Empty;
        [Required]
        public string Email { get; set; }= string.Empty;
        [Required]
        public string Password { get; set; }=string.Empty;
        public Customer? Customer { get; set; }
    }
}
