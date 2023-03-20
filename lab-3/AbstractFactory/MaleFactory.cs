using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MaleFactory : IClothesFactory
    {
        IShoes IClothesFactory.CreateShoes()
        {
            return new MaleShoes();
        }

        ITShirt IClothesFactory.CreateTShirt()
        {
            return new MaleTShirt();
        }
    }
}
