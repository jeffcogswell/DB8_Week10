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
            bool isValid = true;
            if (emp.hiredate < new DateTime(2020, 1, 1) || emp.hiredate > DateTime.Now)
            {
                ViewBag.HireDateMessage = "Please choose a date between Jan 1, 2020 and today.";
                isValid = false;
            }

            if (isValid == false)
            {
                return View("AddForm");
            }

            DAL.AddEmployee(emp);
            return Redirect("/employee");
        }
    }
}
