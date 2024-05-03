using System.ComponentModel.DataAnnotations;

namespace Online_Hotel_Managment_System.Models
{
    public class CustomerMobile
    {
        [Key]
        [Required]
        public int? CustomerMob{ get; set; }
    
        [Key]
        [Required]
        public int customerID { get; set; }
       
       
    }
}
