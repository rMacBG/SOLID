namespace Logger;
using Logger.Appenders;
using Logger.Enums;
using Logger.Interfaces;
using Logger.Layouts;
using Logger.Loggers;

public class Program
{
    public static void Main()
    {
        ILayout simpleLayout = new SimpleLayout();
        ILayout xmlLayout = new XmlLayout(); 
        IAppender consoleAppender = new ConsoleAppender(simpleLayout);
        IAppender fileAppender = new FileAppender("../../../log.txt", xmlLayout, (_, rl, _) => rl >= ReportLevel.Error);
        ILogger logger = new Logger(consoleAppender, fileAppender);

        logger.Error("gosho", "pesho");
        logger.Info("gosho", "[e394284");
    }
}
