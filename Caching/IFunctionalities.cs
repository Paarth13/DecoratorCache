using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caching
{
    interface IFunctionalities
    {
        List<Product> Products();
        Product productById(int Id);
    }
}
