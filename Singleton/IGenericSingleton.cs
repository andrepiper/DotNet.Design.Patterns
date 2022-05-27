using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public interface IGenericSingleton<T>
    {
        void Add(T t);
        List<T> List();
    }
}
