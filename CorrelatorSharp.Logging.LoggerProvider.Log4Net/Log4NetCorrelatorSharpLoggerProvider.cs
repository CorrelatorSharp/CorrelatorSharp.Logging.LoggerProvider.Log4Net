using System;
using System.Diagnostics.CodeAnalysis;
using log4net.Repository;
using Microsoft.Extensions.Logging;

namespace CorrelatorSharp.Logging.LoggerProvider.Log4Net
{
    [ProviderAlias("CorrelatorSharp.Log4Net")]
    [ExcludeFromCodeCoverage]
    public class Log4NetCorrelatorSharpLoggerProvider : CorrelatorSharpLoggerProvider
    {
        public Log4NetCorrelatorSharpLoggerProvider(ILoggerRepository repo = null)
            : base(new Log4NetScopeProvider())
        {
            LoggingConfiguration.Current.UseLog4Net(repo);
        }
    }
}
