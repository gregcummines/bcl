using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class HeyMan
    {
        public void f1()
        {
            Console.WriteLine("Before f2()");
            f2();
            Console.WriteLine("After f2()");
        }

        public async Task<int> f2()
        {
            Console.WriteLine("Enter f2");
            var x = await DoWorkAsync(1000, "hi");
            Console.WriteLine("Exit f2");
            return x;
        }

        public Task<int> DoWorkAsync(int milliseconds, string name)
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
