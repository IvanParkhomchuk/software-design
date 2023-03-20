using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FemaleFactory : IClothesFactory
    {
        IShoes IClothesFactory.CreateShoes()
        {
            return new FemaleShoes();
        }

        ITShirt IClothesFactory.CreateTShirt()
        {
            return new FemaleTShirt();
        }
    }
}
