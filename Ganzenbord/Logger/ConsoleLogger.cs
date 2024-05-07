using Ganzenbord.Business.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Logger
{
    public class ConsoleLogger : ILogger
    {
        public string PrintMessage(string message)
        {
            Console.WriteLine(message);
            return message;
        }

        public string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}
