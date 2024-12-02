using Liskov.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public abstract class EmployedWorker : IWorker
    {
        public abstract void GetPaid();

        public abstract void TakeBreak();

        public abstract void Work();
   
        public decimal Salary { get; set; }
    }
}
