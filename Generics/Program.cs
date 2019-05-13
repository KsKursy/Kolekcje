using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Generic g = new Generic();
            var r = g.GetSum("string", "pupa");
           // var x = g.ReturnT<int>();
            Console.WriteLine(r);
        }
       
    }
}
