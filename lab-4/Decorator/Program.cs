using Decorator;
using Decorator.Heroes;
using Decorator.Inventory;

Hero warrior = new RingOfStrength(new SmallDagger(new Warrior()));
Hero mage = new MagicMantle(new SmallDagger(new Mage()));
Hero palladin = new RingOfStrength(new SmallDagger(new Paladin()));

Console.WriteLine("Warrior mightness: " + warrior.GetMightiness());
Console.WriteLine("Mage mightness: " + mage.GetMightiness());
Console.WriteLine("Palladin mightness: " + palladin.GetMightiness());
