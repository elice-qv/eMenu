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

        public bool Stock { get; } // Food in stock or not

        public double Weight { get; } // Food weight, user can edit value

        public Dish(string name, int cost, bool stock, double weight)
        {
            Name = name;
            Cost = cost;
            Stock = stock;
            Weight = weight;
        }
    }
}
