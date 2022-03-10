using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;

namespace eMenu
{
    public interface IDishRepository
    {
        Dish[] GetByname(string namePart); //method to return value in massive
    }
}
