namespace Logger.Interfaces;

public interface IAppender
{
    bool Append(string dateAndTime, string reportLevel, string message);
}
