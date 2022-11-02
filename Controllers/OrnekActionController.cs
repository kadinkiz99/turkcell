using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace turkcell.Controllers
{
	public class OrnekActionController : Controller
	{
		public class Product
		{
			public int Id { get; set; }
			public string name { get; set; }
		}
		public IActionResult Index()
		{
			/* 
			ViewBag.name = "Asp.Net Core";

			ViewData["names"] = new List<string>(){ "ahmet ", "mehmet ", "ali" };

			ViewBag.person = new{ Id = 5, name = "kadınkız ", age = 25 };

			*/

			///temp data 

			//	TempData["surname"] = "Önal";


			//ViewModel

			var ProductList = new List<Product>()
			{
				new(){Id = 1 ,name="Ali"},
				new(){Id = 2 ,name="ahmet "},
				new(){Id = 3 ,name="mehmet"}

			};

			return View(ProductList);
		}

		public IActionResult Index2()
		{

			return View();

		}


		/*
		 * RedirectionAction metot ile açılan sayfadan farklı bir sayfaya yönlendirme işlemi yapılır . 
		 * Mesel akullanıcı kayıt ekranı geldi ve bilgiler alındıktan sonra yeni ekrana yönlendirmek için kullanılır . 
		 * 
		public IActionResult Index2()
		{
			return RedirectToAction("Index", "OrnekAction");
		}
		
		*/
	}
}
