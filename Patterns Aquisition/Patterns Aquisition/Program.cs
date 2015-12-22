using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Aquisition
{
    class Program
    {
        static void Main(string[] args)
        {
            new Runner().run();

        }



        private class Runner
        {
            public Runner()
            {
            }

            public void run()
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
