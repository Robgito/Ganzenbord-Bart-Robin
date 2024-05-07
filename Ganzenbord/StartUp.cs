using Ganzenbord.Business.Dice;
using Ganzenbord.Business.Logger;
using Ganzenbord.Logger;
using GanzenBord.Business;
using GanzenBord.Business.Factories;
using GanzenBord.Business.Spaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord
{
    public class StartUp
    {
        public ServiceCollection RegisterServices()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<ILogger, ConsoleLogger>();
            services.AddScoped<IDice, Dice>();
            services.AddScoped<IPlayerFactory, PlayerFactory>();
            services.AddScoped<ISpaceFactory, SpaceFactory>();
            services.AddSingleton<IBoard, Board>();
            services.AddSingleton<IGame, Game>();

            return services;
        }
    }
}
