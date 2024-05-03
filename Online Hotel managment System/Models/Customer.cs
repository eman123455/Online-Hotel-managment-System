using System.ComponentModel.DataAnnotations;

namespace Online_Hotel_Managment_System.Models
{
    public class Customer
    {
        [Key]
        public int Cust_Id { get; set; }
        public string F_Name { get; set; }

        public string L_Name { get; set; }
        public string Gender { get; set; }
        public string City{ get; set; }
        public String PinCode { get; set; }
        public DateTime BD { get; set; }
        ////////
        public Room Room { get; set; }
        //public List<Payment> payments { get; set; }
    }
}
