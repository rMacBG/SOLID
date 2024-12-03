using Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Appenders
{
    public class ConsoleAppender : IAppender
    {
        private readonly ILayout _layout;

        public ConsoleAppender(ILayout layout)
        {
            this._layout = layout ?? throw new ArgumentNullException(nameof(layout));
        }
        public bool Append(string dateAndTime, string reportLevel, string message)
        {
            string formattedLogMessage = this._layout.Format(dateAndTime, reportLevel, message);

            Console.WriteLine(formattedLogMessage);
            return true;
        }
    }
}
