using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Character
    {
        public string Name { get; set; }
        public string Faction { get; set; }
        public string Guild { get; set; }
        public string MeleeWeapon { get; set; }
        public string RangeWeapon { get; set; }
        public string Armor { get; set; }

        public void Display()
        {
            Console.WriteLine($"\tName: {Name}");
            Console.WriteLine($"\tFaction: {Faction}");
            Console.WriteLine($"\tGuild: {Guild}");
            Console.WriteLine($"\tMeleeWeapon: {MeleeWeapon}");
            Console.WriteLine($"\tRangeWeapon: {RangeWeapon}");
            Console.WriteLine($"\tArmor: {Armor}");
        }
    }
}
