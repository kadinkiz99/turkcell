using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using turkcell.Helpers;
using turkcell.Models;

namespace turkcell.Controllers
{
    public class ProductsController : Controller
    {
        
        AppDbContext _appDbContext;
        // önceden tanımladığımız repo projeye eklendi 
        private readonly ProductRepository _productRepository;
      // private IHelper _helper; 
        public ProductsController( )
        {
            _productRepository = new ProductRepository();
           _appDbContext = new AppDbContext(); 
           // _helper = helper;   
        }
        
		public IActionResult Index()
        {
			var products = _appDbContext.Products.ToList(); 
            return View(products);


        }
        
        
        public IActionResult Remove(int id)
        {
            var product = _appDbContext.Products.Find(id);
            //prinarykey değerlerinin bulunup silinmesi için find metotu kullanılır . 
            _appDbContext.Products.Remove(product);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
       
        public IActionResult Add()
        {

            ViewBag.Expire = new Dictionary<string, int>()
            {
                {"1 ay ", 1 },
				{"3 ay ",  3},
				{"6 ay ",  6},
				{"12 ay ",12}



			};
            ViewBag.ColorSelect = new SelectList(new List<ColorSelectList>()
            {
                new (){Data = "Mavi", Value="Mavi"},
				new (){Data = "Kırmızı", Value="Kırmızı"},
				new (){Data = "Sarı", Value="Sarı"},
				new (){Data = "Yeşil", Value="Yeşil"}
			},"Value","Data");
            return View();

        }

        [HttpPost]
		//1. ve 2. yöntem için 
		//public IActionResult Add(string Name , decimal Price , int Stock ,string color )
		public IActionResult Add(Product product)
		{
            ////1. yöntem 
            //var name = HttpContext.Request.Form["Name"].ToString();
            //var Price = decimal.Parse(HttpContext.Request.Form["Price"].ToString());
            //var Stock = int.Parse(HttpContext.Request.Form["Stock"].ToString());
            //var color = HttpContext.Request.Form["color "].ToString();

            // 2. yöntem 
            /*Product newProduct = new Product() { Name = Name, Price = Price, Stock = Stock, color = color };
            _appDbContext.Products.Add(newProduct);
            */
            _appDbContext.Products.Add(product);
            

            //request -Head -Body 

            _appDbContext.SaveChanges();
			TempData["status"] = "Ürün başarıyla Eklendi";

			return RedirectToAction("Index");
        }
		public IActionResult Update(int id)
		{
            var product =_appDbContext.Products.Find(id);   
			return View(product);

		}
        [HttpPost]
		public IActionResult Update(Product updateproduct ,int productId)
		{
            //query string kullanark id gönderme işlemi 
            updateproduct.id = productId;
			_appDbContext.Products.Update(updateproduct);
            _appDbContext.SaveChanges();
            TempData["status"] = "Ürün başarıyla Güncellendi";
			return RedirectToAction("Index");

		}
	}
}
