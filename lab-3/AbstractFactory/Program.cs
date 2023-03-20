using AbstractFactory;

static void ReleaseClothes(IClothesFactory factory)
{
    var shoes = factory.CreateShoes();
    var tshirt = factory.CreateTShirt();

    shoes.ReleaseShoes();
    tshirt.ReleaseTShirt();

    Console.WriteLine();
}

ReleaseClothes(new MaleFactory());
ReleaseClothes(new FemaleFactory());
ReleaseClothes(new ChildFactory());

Console.ReadLine();