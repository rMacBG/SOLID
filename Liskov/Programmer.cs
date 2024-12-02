using Liskov.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Programmer : EmployedWorker, IWorker
    {
        public override void GetPaid()
        {
            Console.WriteLine("Spend everything");
        }

        public override void TakeBreak()
        {
            Console.WriteLine("no turning");
        }

        public override void Work()
        {
            Console.WriteLine("Waiting for a break");
        }
    }
}
