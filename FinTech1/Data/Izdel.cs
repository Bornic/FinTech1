using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTech1.Data
{

    
    class Izdel
    {
        Int64 id;
        public Int64 Id
        {
            get { return id; }
            set { id = value; }
        }

        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Izdel(Int64 Id, string Name, double Price)
        {
            id = Id;
            name = Name;
            price = Price;

        }

    }
}
