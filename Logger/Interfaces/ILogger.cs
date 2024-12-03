namespace Logger.Interfaces;

public interface ILogger
{
    void Info(string dateAndTime, string message);
    void Warning(string dateAndTime, string message);
    void Error(string dateAndTime, string message);
    void Critical(string dateAndTime, string message);
    void Fatal(string dateAndTime, string message);
}
