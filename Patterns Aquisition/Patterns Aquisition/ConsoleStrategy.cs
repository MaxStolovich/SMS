using System;

namespace Patterns_Aquisition
{
    internal class ConsoleStrategy : Strategy
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}