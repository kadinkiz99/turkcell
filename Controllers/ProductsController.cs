using Microsoft.AspNetCore.Mvc;
using System.Linq;
using turkcell.Models;

namespace turkcell.Controllers
{
    public class ProductsController : Controller
    {
        
        AppDbContext _appDbContext;
        // önceden tanımladığımız repo projeye eklendi 
        private readonly ProductRepository _productRepository;
      
        public ProductsController()
        {
            _productRepository = new ProductRepository();
           _appDbContext = new AppDbContext(); 
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

        return RedirectToAction("Index");
        }
		public IActionResult Update(int id)
		{
			return View();

		}
	}
}
