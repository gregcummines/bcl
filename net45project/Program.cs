using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net45project
{
    class Program
    {
        static void Main(string[] args)
        {
            greg();

            Console.WriteLine("After call to greg");

            Console.ReadKey();
        }

        async static void greg()
        {
            var geez = new HeyMan();
             geez.f2();
            Console.WriteLine("After call to f2()");

        }
    }
}
