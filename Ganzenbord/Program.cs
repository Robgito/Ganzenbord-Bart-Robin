
using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Spaces;
using Ganzenbord.Logger;
using GanzenBord.Business;
using GanzenBord.Business.Factories;
using Microsoft.Extensions.DependencyInjection;

namespace Ganzenbord
{
    internal class Program
    {
        static void Main(string[] args)
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
