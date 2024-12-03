﻿using Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Layouts
{
    public class SimpleLayout : ILayout
    {
        public string Format(string dateAndTime, string reportLevel, string message)
        => $"{dateAndTime} - {reportLevel} - {message}";
    }
}
