using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ChildFactory : IClothesFactory
    {
        IShoes IClothesFactory.CreateShoes()
        {
            return new ChildShoes();
        }

        ITShirt IClothesFactory.CreateTShirt()
        {
            return new ChildTShirt();
        }
    }
}
