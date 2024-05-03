using System.ComponentModel.DataAnnotations;

namespace Online_Hotel_Managment_System.Models
{
    public class Room
    {
        [Key]
        public int Room_ID { get; set; }
        public String Room_Type { get; set; }
        public String Room_State { get; set; }
        //forgin key
        public Hotel Hotel { get; set; }
        public List<Customer> Customer { get; set; }
    }
}
