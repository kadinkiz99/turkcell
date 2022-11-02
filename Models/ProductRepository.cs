using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using turkcell.Models;

namespace turkcell.Models
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>();   

        public List<Product> GetAll() => _products;

        public void Add(Product newProduct) => _products.Add(newProduct);

        public void Remove(int id)
        {
            var hasProduct = _products.FirstOrDefault(x => x.id == id); 

            if (hasProduct == null)
            {
                throw new Exception($"Bu id ({id}) ye sahip ürün bulunmamaktadır .");
            
            }
            _products.Remove(hasProduct);   

        }

        public void Update(Product updateProduct)
        {
			var hasProduct = _products.FirstOrDefault(x => x.id == updateProduct.id);

			if (hasProduct == null)
			{
				throw new Exception($"Bu id ({updateProduct.id}) ye sahip ürün bulunmamaktadır .");

			}
			hasProduct.Name = updateProduct.Name;
			hasProduct.Price = updateProduct.Price;
			hasProduct.Stock= updateProduct.Stock;
            
            var index = _products.FindIndex(x => x.id == updateProduct.id);
            _products[index] = updateProduct;   


		}

	}
}
