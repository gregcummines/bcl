using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            greg();
            
            
        }

        static async greg()
        {
            var geez = new HeyMan();
            await geez.f1();
            Console.WriteLine("After call to f1()");
            Console.ReadKey();

        }
    }
}
