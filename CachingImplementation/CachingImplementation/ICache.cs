using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CachingImplementation
{
    interface ICache
    {
        void Add(string key, Object o);

        Object Get(string key);

        Object Update(string id, Object o);

        void Remove(string key);

        void Clear();
    }
}
