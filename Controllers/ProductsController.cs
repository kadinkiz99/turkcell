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
            _productRepository.Remove(id);
            return RedirectToAction("Index");
        }
       
        public IActionResult Add()
        {
            return View();

        }
		public IActionResult Update(int id)
		{
			return View();

		}
	}
}
