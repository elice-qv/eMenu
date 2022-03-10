using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMenu
{
    public class Dish
    {

        public string Name { get; } // Food names

        public int Cost { get; } // Food cost

        public bool Stock { get; }

        public double Weight { get; }

        public Dish(string name, int cost, bool stock, double weight)
        {
            Name = name;
            Cost = cost;
            Stock = stock;
            Weight = weight;
        }
    }
}
