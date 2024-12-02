
using OpenClosedPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Promotions
{
    public class MondayPromotion : IPromotion
    {
        public decimal GetPrice(decimal price)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday) return price *= 0.9m;

            return price;
        }
    }
}
