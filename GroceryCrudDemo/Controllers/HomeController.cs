using GroceryCrudDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GroceryCrudDemo.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			// Here's some test code we can try to make sure 
			// our first DAL function works.
			List<Category> cats = DAL.GetAllCategories();
			ViewBag.count = cats.Count;
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}