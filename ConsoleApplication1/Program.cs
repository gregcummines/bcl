using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before f1()");
            f1();
            Console.WriteLine("After f1()");
            Console.ReadKey();
        }

        async static void f1()
        {
            await DoWorkAsync(1000, "hi");
        }

        static Task<int> DoWorkAsync(int milliseconds, string name)
        {
            //error appears below on word Run
            return Task.Factory.StartNew(() =>
            {
                Console.WriteLine("* starting {0} work", name);
                Thread.Sleep(milliseconds);
                Console.WriteLine("* {0} work one", name);
                return 1;
            });
        }
    }
}
