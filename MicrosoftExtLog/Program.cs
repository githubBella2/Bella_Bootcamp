using Microsoft.Extensions.Logging;

class Program
{
    static void Main(string[] args)
    {
        ILoggerFactory loggerFactory = LoggerFactory.Create(builder => {
            builder.AddConsole().SetMinimumLevel(LogLevel.Debug);
        });

        ILogger logger = loggerFactory.CreateLogger<Program>();
        logger.LogDebug("This is a debug message");
        logger.LogInformation("This is a information message");
        logger.LogCritical("This is critial");
        logger.LogTrace("This is Log Trace ");
    }
}