using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Generic
    {
        public T GetSum<T>(T first, T second)
        {
            dynamic f = first;
            dynamic s = second;
            return f + s;
        }
        public T ReturnT<T>() where T : class, new()
        {
            return new T();
        }
    }
}
