using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetFaction(string faction);
        ICharacterBuilder SetGuild(string guild);
        ICharacterBuilder SetMeleeWeapon(string meleeWeapon);
        ICharacterBuilder SetRangeWeapon(string rangeWeapon);
        ICharacterBuilder SetArmor(string armor);
        Character GetCharacter();
    }
}
