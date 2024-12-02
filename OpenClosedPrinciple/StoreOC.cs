using OpenClosedPrinciple.Interfaces;
using OpenClosedPrinciple.Promotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class StoreOC
    {
        private List<IPromotion> promotions;
        public StoreOC()
        {
            Products = new List<Product>();
            promotions = new List<IPromotion>()
            {
                new ChristmasPromotion(),
                new MondayPromotion(),
                new DecemberPromotion(),
                new FaithfulUsersPromotion(),
            };
        }
        public List<Product> Products { get; set; }


        public decimal GetProductPrice(string name)
        {
            Product product = Products.FirstOrDefault(x => x.Name == name);

            decimal price = product.Price;

            foreach (var promotion in promotions)
            {
                price = promotion.GetPrice(price);
            }

            return price;
        }

        public string GetProductName(string name)
        {
            Product product = Products.FirstOrDefault(x => x.Name == name.ToString());
            name = product.Name;
            return name;
        }
    }
}
