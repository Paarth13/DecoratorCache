using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caching
{
    class Program
    {
        static void Main(string[] args)
        {
            IFunctionalities functionality = new CacheFunctionalities();
            List<Product> products = functionality.Products();
            int id = int.Parse(Console.ReadLine());
            Product product = functionality.productById(id);
            Console.WriteLine(product.id);
            product = functionality.productById(id);
            Console.ReadKey();
        }
    }
}
