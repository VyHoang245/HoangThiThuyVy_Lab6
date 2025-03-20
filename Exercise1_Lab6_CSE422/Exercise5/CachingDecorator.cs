using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class CachingDecorator<T> : IDataService<T>
    {
        private readonly IDataService<T> _innerService;
        private readonly Dictionary<int, T> _cache = new Dictionary<int, T>();

        public CachingDecorator(IDataService<T> innerService)
        {
            _innerService = innerService;
        }

        public T GetData(int id)
        {
            if (_cache.ContainsKey(id))
            {
                Console.WriteLine("Fetching from cache...");
                return _cache[id];
            }

            T data = _innerService.GetData(id);
            _cache[id] = data;
            return data;
        }
    }

}
