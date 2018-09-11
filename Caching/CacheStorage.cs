using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Caching
{
    class CacheStorage
    {
        MemoryCache cache = new MemoryCache("CachingProvider");
        public void Add(string key,Object value)
        {
            Console.WriteLine("Adding to Cache");
            cache.Add(key, value, DateTime.Now.AddSeconds(20));
        }

        public void Remove(string key)
        {
            cache.Remove(key);
        }

        public object GetOne(string key)
        {
            Console.WriteLine("Getting from  Cache");
            var obj = cache[key];
            return obj;
        }
    }
}
