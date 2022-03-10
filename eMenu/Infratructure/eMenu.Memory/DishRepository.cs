using System;
using System.Linq;

namespace eMenu.Memory
{
    public class DishRepository : IDishRepository
    {
         private readonly Dish[] dishes = new[]
         {
             new Dish("Зеленый борщ", 10, true, 0.300),
             new Dish("Шашлык из баранины", 20, true, 0.100),
             new Dish("Сок в ассортименте", 30, false, 0.200),
         };


        public Dish[] GetByname(string namePart)
        {
            return dishes.Where(dish => dish.Name.Contains(namePart))
                .ToArray();
        }
    }
}
