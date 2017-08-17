using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CachingImplementation
{
   
    public class Cache
    {
        public int count
        {
            get { return _cache.Count; }
        }
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

        public Object Retrieve(string key)
        {
            return _cache[key];
        }

        public Object Update(string id,Object o)
        {
            _cache[id] = new WeakReference(o, false);
            return _cache;
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }

        public void Clear()
        {
            _cache=new Dictionary<string, WeakReference>();
        }

       
    }

   

}

