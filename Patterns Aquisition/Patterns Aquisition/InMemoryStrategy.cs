using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Aquisition
{
    class InMemoryStrategy : Strategy
    {
        private List<string> messages = new List<string>();


        public void Print(string message)
        {
            messages.Add(message);
        }

        

           
        

    }
}
