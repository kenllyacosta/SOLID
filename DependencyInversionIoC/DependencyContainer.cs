using DependencyInversionAbstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace DependencyInversionIoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddLoggers(this IServiceCollection services)
        {
            services.AddScoped<ILogger, DependencyInversionConsoleLoggerLibrary.ConsoleLogger>();
            services.TryAddScoped<ILogger, DependencyInversionFileLoggerLibrary.FileLogger>();
            return services;
        }
    }
}
