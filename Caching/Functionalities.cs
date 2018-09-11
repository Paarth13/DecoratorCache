using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caching
{
    class Functionalities : IFunctionalities
    {
        public List<Product> Products()
        {
            IRepository productR = new Sql();
            //Console.WriteLine("From DataBAse");
            return productR.GetAll();
        }
        public Product productById (int id)
        {
            IRepository productR = new Sql();
            Console.WriteLine("From DataBAse");
            return productR.GetById(id);
        }
    }
}
