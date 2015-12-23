using System;
using System.Collections.Generic;

namespace Patterns_Aquisition
{
    internal class Adapter : Target
    {
        private Strategy strategy;

        public Adapter(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void AddMessage(string[] v)
        {
            foreach (string message in v)
                strategy.Print(message);
        }
    }
}