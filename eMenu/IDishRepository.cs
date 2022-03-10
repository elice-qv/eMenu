using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;

namespace eMenu
{
    interface IDishRepository
    {
        Dish[] GetByName(string namePart);
    }
}
