using System.ComponentModel.DataAnnotations;

namespace Online_Hotel_Managment_System.Models
{
    public class Employee
    {
        [Key]
        public int Emp_ID { get; set; }
        public String Emp_Name { set; get; }
        public String Address { set; get; }
        public String job_Description { set; get; }
        //forgin keys for hotel
        public int HotelId { get; set; }
        public Hotel Hotel { set; get; }
   

    }
}
