using GanzenBord.Business;
using Microsoft.Extensions.DependencyInjection;

namespace Ganzenbord
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;
            ServiceCollection serviceCollection = new StartUp().RegisterServices();
            ServiceProvider provider = serviceCollection.BuildServiceProvider();
            IGame game = provider.GetService<IGame>();

            game.StartGame();
            game.MultiplayerCreation();
            game.GameLoop();
            game.EndGame();
        }
    }
}