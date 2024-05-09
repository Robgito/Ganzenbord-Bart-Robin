using GanzenBord.Business;
using Microsoft.Extensions.DependencyInjection;

namespace Ganzenbord
{
    internal class Program
    {
        private static void Main(string[] args)
        {
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