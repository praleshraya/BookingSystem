using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(50)]
        public required string UserFirstName { get; set; }
        [StringLength(50)]
        public string UserMiddleName { get; set; }
        [StringLength(50)]
        public required string UserLastName { get; set; }
        [StringLength(100)]
        public  string UserAddress { get; set; }
        
        [Required]
        [StringLength(100)]
        public required string UserEmail { get; set; }
        [Required]
        public required string UserPassword { get; set; }
        [Required]
        public required bool gender {  get; set; }
                
    }
}
