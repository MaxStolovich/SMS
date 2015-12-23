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
            new Runner(new Adapter(ConsoleStrategy.GetInstance())).run();

        }



        private class Runner : Component
        {
            private Target target;

            public Runner(Target t)
            {
                this.target = t;
            }

            public void run()
            {
                target.AddMessage(new string[] { "Hello World!"} );
            }
        }
    }

    public interface Strategy
    {
        void Print(string message);
    }
}
