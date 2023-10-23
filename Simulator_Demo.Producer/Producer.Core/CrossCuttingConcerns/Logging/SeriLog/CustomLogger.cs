using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer.Core.CrossCuttingConcerns.Logging.SeriLog;

public class CustomLogger : ILogger
{
    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        return null;
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return true;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        string logMessage = formatter(state, exception);
        logMessage = $"[{DateTime.Now:dd.MM.yyyy HH.mm.ss}] - {logMessage}";
        Console.WriteLine(logMessage);
    }
}
