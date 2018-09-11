using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caching
{
    class CacheFunctionalities:IFunctionalities
    {
        private IFunctionalities _service;
        private CacheStorage _memoryCachProvider;
        public CacheFunctionalities()
        {
            _service = new Functionalities();
            _memoryCachProvider = new CacheStorage();
        }
        public Product productById(int id)
        {
            Product product = (Product)_memoryCachProvider.GetOne(Convert.ToString(id));
            if (product != null)
            {
                Console.WriteLine("Getting Product " + id + " From Cache");
                return product;
            }
            product = _service.productById(id);
            _memoryCachProvider.Add(Convert.ToString(product.id), product);
            return product;
        }

        public List<Product> Products()
        {
            List<Product> products = _service.Products();
           
            return products;
        }
    }
}
