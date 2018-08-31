using Bomholt.PetShop.UI.InterF;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Bomholt.PetShop.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            //serviceCollection.AddScoped<IVideoRepository, VideoRepository>();
            //serviceCollection.AddScoped<IVideoService, VideoService>();
            serviceCollection.AddScoped<ILogic, Logic>();
            serviceCollection.AddScoped<IRunProgram, RunProgram>();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var runprogram = serviceProvider.GetRequiredService<IRunProgram>();

            runprogram.Run();
        }
    }
}
    