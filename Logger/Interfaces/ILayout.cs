namespace Logger.Interfaces;

public interface ILayout
{
    string Format(string dateAndTime, string reportLevel, string message);
}
