using Ganzenbord.Business.Logger;

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

        public void WriteEmptyLine()
        {
            Console.WriteLine("");
        }

        public void ClearConsole()
        {
            Console.Clear();
        }
    }
}