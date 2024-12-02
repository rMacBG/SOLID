using Liskov.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Company
    {
        
        public Company()
        {
            Workers = new List<IWorker>();   
            EmployedWorkers = new List<EmployedWorker>();
        }
        public List<IWorker> Workers { get; set; }
        public List<EmployedWorker> EmployedWorkers { get; set; }

        public void Work()
        {
            foreach (var worker in Workers)
            {
                worker.Work();
            }
        }

        public void TakeBreak()
        {
            foreach(var worker in EmployedWorkers)
            {
                //this is ultimately wrong cuz "is"
                //if (worker is Robot)
                //{
                //    continue;
                //}
                //after change now Liskov is not broken
                worker.TakeBreak();
            }
        }
    }
}
