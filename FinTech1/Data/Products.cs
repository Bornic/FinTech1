using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTech1.Data
{
   
    class Products
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }


        double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        double cost;
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public Products(string Name, int Count, double Price, double Cost)
        {

            name = Name;
            count = Count;
            price = Price;
            cost = Cost;


        }
    }
}
