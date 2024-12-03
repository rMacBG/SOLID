

namespace Logger;

using Logger.Appenders;
using Logger.Interfaces;
using Logger.Layouts;
using Logger.Loggers;

public class Program
{
    public static void Main()
    {
        ILayout simpleLayout = new SimpleLayout();
        IAppender consoleAppender = new ConsoleAppender(simpleLayout);
        ILogger logger = new Logger(consoleAppender);

        logger.Error("gosho", "pesho");
        logger.Info("gosho", "[e394284");
    }
}
