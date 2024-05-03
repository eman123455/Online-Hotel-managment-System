 using Microsoft.AspNetCore.Mvc;
using Online_Hotel_Managment_System.Models;

namespace Online_Hotel_Managment_System.Controllers
{
    public class EmpController : Controller
    {
        public EmpController(AppDBContext DB) {
        this.DB = DB;
        }
        private readonly AppDBContext DB;

        public IActionResult Index()
        {
            //list go to view
            IEnumerable<Employee> EmpList = DB.employees;
            return View(EmpList);
        }
        //get
        public IActionResult NewEmp()
        {
            //list go to view
            return View();
        }//delete
       
        //get
        public IActionResult Edit(int? id)
        {
          var item=DB.employees.Find(id);
            return View(item);
        }
        //posts
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (employee.Emp_Name.Length <= 1)
            {
                ModelState.AddModelError("EmployeeError", "invalidname");
            }
            if (employee.job_Description.Length <= 1)
            {
                ModelState.AddModelError("EmployeeError", "invalidname");
            }
            if (ModelState.IsValid)
            {
                    
                DB.employees.Update(employee);
                DB.SaveChanges();
                //list go to view
                return RedirectToAction("Index");
            }
            else
            {
                return View(employee);
            }
        }
        //post
        [HttpPost]
        public IActionResult NewEmp(Employee employee)
        {
            //if (employee.Emp_Name.Length <= 1)
            //{
            //    ModelState.AddModelError("EmployeeError","invalidname")  ;     
            //}
            //if (employee.job_Description.Length <= 1)
            //{
            //    ModelState.AddModelError("EmployeeError", "invalidname");
            //}
            //if (ModelState.IsValid)
            //{
            //    DB.employees.Add(employee);
            //    DB.SaveChanges();
            //    //list go to view
            //    return RedirectToAction("Index");
            //}
            //else { 
            //    return View(employee);
            //

            DB.employees.Add(employee);
            DB.SaveChanges();
            //list go to view
            return RedirectToAction("Index");
        }

        //Delete
        public IActionResult delete(int? id)
        { 
                var item=DB.employees.Find(id);
                DB.employees.Remove(item);
                DB.SaveChanges();
                //list go to view
                return RedirectToAction("Index");
          
        }
    }
}
