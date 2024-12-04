using Logger.Enums;
using Microsoft.VisualBasic;

namespace Logger.Interfaces;



public interface ILogger
{
    void Log(string dateAndTime, ReportLevel reportLevel, string message);

    void Info(string dateAndTime, string message) 
        => Log(dateAndTime, ReportLevel.Info, message);

    void Warning(string dateAndTime, string message)
        => Log(dateAndTime, ReportLevel.Warning, message);

    void Error(string dateAndTime, string message)
        => Log(dateAndTime, ReportLevel.Error, message);

    void Critical(string dateAndTime, string message)
        => Log(dateAndTime, ReportLevel.Critical, message);

    void Fatal(string dateAndTime, string message)
        => Log(dateAndTime, ReportLevel.Fatal, message);


}
