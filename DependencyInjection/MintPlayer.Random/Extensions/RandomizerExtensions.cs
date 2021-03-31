using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace MintPlayer.Random.Extensions
{
    public static class RandomizerExtensions
    {
        public static IServiceCollection AddRandomizer(this IServiceCollection services)
        {
            return services
                .AddTransient<Abstractions.IRandomizer, Randomizer>();
        }
    }
}
