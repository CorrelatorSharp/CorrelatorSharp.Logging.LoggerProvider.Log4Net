using System;

namespace CorrelatorSharp.Logging.LoggerProvider.Log4Net
{
    public class Log4NetScopeProvider : IScopeProvider
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            // TODO - Allow the user to provide some extra form of scope.
            return null;
        }

        public void ErrorBuildingScope(Exception exception)
        {
            
        }
    }
}
