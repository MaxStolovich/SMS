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
            new Runner(new ConsoleStrategy.getInstance()).run();

        }



        private class Runner
        {
            private Strategy strategy;

            public Runner(Strategy strategy)
            {
                this.strategy = strategy;
            }

            public void run()
            {
                strategy.Print("Hello World!");
            }
        }
    }

    public interface Strategy
    {
        void Print(string message);
    }
}
