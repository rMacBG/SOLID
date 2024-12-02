using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class Store
    {
        public Store()
        {
            Products = new List<Product>();
        }
        public List<Product> Products { get; set; }


        public decimal GetProductPrice(string name)
        {
            Product product = Products.FirstOrDefault(x => x.Name == name);

            decimal price = product.Price;

            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                price *= 0.8m;
            }
            if (DateTime.Now.Date.Day == 1)
            {
                price *= 0.7m;
            }
            if (DateTime.Now.Date.Month == 12 &&  DateTime.Now.Date.Day == 25)
            {
                price *= 0.6m;
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
