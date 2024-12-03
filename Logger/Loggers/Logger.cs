using Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Loggers
{
    public class Logger : ILogger
    {
        private readonly IAppender[] _appenders;
        public Logger(params IAppender[] appenders)
        {
            this._appenders = appenders;
        }

        public void Critical(string dateAndTime, string message)
        => this.Log(dateAndTime, nameof(Critical), message);

        public void Error(string dateAndTime, string message)
        => this.Log(dateAndTime, nameof(Error), message);

        public void Fatal(string dateAndTime, string message)
        => this.Log(dateAndTime, nameof(Fatal), message);
        public void Info(string dateAndTime, string message)
        => this.Log(dateAndTime, nameof(Info), message);

        public void Warning(string dateAndTime, string message)
        => this.Log(dateAndTime, nameof(Warning), message);

        private void Log(string dateAndTime,string reportLevel, string message)
        {
            foreach (IAppender appender in this._appenders)
            {
                appender.Append(dateAndTime, reportLevel, message);
            }
        }
    }
}
