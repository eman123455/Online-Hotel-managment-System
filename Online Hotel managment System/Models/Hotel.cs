using System.ComponentModel.DataAnnotations;

namespace Online_Hotel_Managment_System.Models
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        public String HotelName { get; set;}
        public String Location { get; set; }
     //Emp
         public List<Employee> Employees { get; set; }
         public List<Room> Rooms { get; set; }
       
       //public Hotel(Employee e)
       // {
       //     HotelId = e.HotelId;
       // }


    }
}
