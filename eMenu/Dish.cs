using System;

namespace eMenu
{
    public class Dish
    {
        public string Name { get; }

        public int Price { get; }

        public bool Stock { get; } //В наличии блюдо или нет

        public decimal Weight { get; } //стандартная масса блюд

        public Dish(string name, int price, bool stock, decimal weight) //инициализация параметров класса
        {
            Name = name;
            Price = price;
            Stock = stock;
            Weight = weight;
        }
    }
}
