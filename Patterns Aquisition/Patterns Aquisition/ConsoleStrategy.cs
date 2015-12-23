using System;

namespace Patterns_Aquisition
{
    internal class ConsoleStrategy : Strategy
    {
        private ConsoleStrategy()
        { }
        private static Strategy instance;
        public static Strategy GetInstance()
        {
            return instance=(instance==null)? new ConsoleStrategy():instance;
        }
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}