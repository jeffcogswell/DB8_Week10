using Microsoft.AspNetCore.Mvc;
using BusinessV2Demo.Models;

namespace BusinessV2Demo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> emps = DAL.GetAllEmployees();
            return View(emps);
        }

        public IActionResult AddForm()
        {
            return View();
        }

        public IActionResult Add(Employee emp)
        {
            DAL.AddEmployee(emp);
            return Redirect("/employee");
        }
    }
}
