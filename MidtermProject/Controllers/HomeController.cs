using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MidtermProject.Models;

namespace MidtermProject.Controllers
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
			Student S1 = new Student()
			{
				StudentId = 12,
				FirstName = "Raven",
				LastName = "Murray",
				CourseId = 1,
				CourseEnrolledDate = DateTime.Now,
				CourseStatus = 1,
				Grade = "A"
			};

			Student S2 = new Student()
			{
				StudentId = 16,
				FirstName = "Mariah",
				LastName = "West",
				CourseId = 2,
				CourseEnrolledDate = DateTime.Now,
				CourseStatus = 7,
				Grade = "B"
			};

			List<Student> Kids = new List<Student>();
			Kids.Add(S1);
			Kids.Add(S2);




			return View(Kids);
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
