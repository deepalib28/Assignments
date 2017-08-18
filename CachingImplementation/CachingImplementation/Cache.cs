using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CachingImplementation
{
   
    public class Cache:ICache
    {
       
        private Dictionary<string, WeakReference> _cache { get; set; }

        public Cache()
        {
            _cache = new Dictionary<string, WeakReference>();
        }
        
        public void Add(string key,Object o)
        {
            if(string.IsNullOrEmpty(key)==false && o!=null&&_cache.ContainsKey(key)==false)
            _cache.Add(key, new WeakReference(o, false));
        }

        public Object Get(string key)
        {
           
            if(string.IsNullOrEmpty(key)==false && _cache.ContainsKey(key))
            return _cache[key].Target;

            return new Exception("Key not Found exception");

        }

        public Object Update(string key,Object o)
        {
            if (string.IsNullOrEmpty(key) == false && _cache.ContainsKey(key))
                _cache[key] = new WeakReference(o, false);
            else
                _cache.Add(key, new WeakReference(o, false));

            return _cache;
        }

        public void Remove(string key)
        {
            if(string.IsNullOrEmpty(key) == false && _cache.ContainsKey(key))
                _cache.Remove(key);

        }

        public void Clear()
        {
            _cache=new Dictionary<string, WeakReference>();
        }

       
    }

   

}

