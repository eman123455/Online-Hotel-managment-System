using System.ComponentModel.DataAnnotations;

namespace Online_Hotel_Managment_System.Models
{
    public class EmpMobile
    {
        [Key]
        public int Mobile_No { get; set; }
        [Key]
        public int EmployeeID { get; set; }
        
    }
}
