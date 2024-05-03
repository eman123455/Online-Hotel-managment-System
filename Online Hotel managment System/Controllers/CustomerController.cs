using Microsoft.AspNetCore.Mvc;

namespace Online_Hotel_Managment_System.Controllers
{
    public class CustomerController : Controller
    {
        public CustomerController(AppDBContext data) {
            this.data = data;
        }
        private readonly AppDBContext data;
        public IActionResult Index()
        {
            return View();
        }
    }
}
