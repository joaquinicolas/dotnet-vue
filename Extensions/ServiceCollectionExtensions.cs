using Microsoft.Extensions.DependencyInjection;

namespace dotnet_vue.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWeather(this IServiceCollection services)
        {
            // All add weather related DI.
            services.AddSingleton<Providers.IWeatherProvider, Providers.WeatherProviderFake>();

            return services;
        }
    }
}
