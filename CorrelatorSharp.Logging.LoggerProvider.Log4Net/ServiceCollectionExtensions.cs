using CorrelatorSharp.Logging.LoggerProvider.Log4Net;
using log4net.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CorrelatorSharp.Logging
{
    public static class ServiceCollectionExtensions
    {
        public static void UseCorrelatorSharpLog4NetLoggerProvider(this IServiceCollection serviceCollection, ILoggerRepository repo = null)
        {
            serviceCollection.AddSingleton<ILoggerProvider>(new Log4NetCorrelatorSharpLoggerProvider(repo));
        }
    }
}