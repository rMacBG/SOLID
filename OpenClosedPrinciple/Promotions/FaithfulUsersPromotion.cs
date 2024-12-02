using OpenClosedPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Promotions
{
    public class FaithfulUsersPromotion : IPromotion
    {
        public decimal GetPrice(decimal price)
        {
            if (price < 0)
            {
                Console.WriteLine("Checking if the user has been with us for 5 years and more");
                //
                //
                //
                Console.WriteLine("Checking if the user has spent over 5k lv.");
                //
                //
                //
                Console.WriteLine("Checking age > 30");
                //

                return price * 0.9m;
            }
            return price;
        }
    }
}
