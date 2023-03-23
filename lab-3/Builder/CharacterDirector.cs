using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CharacterDirector
    {
        private ICharacterBuilder _characterBuilder;

        public CharacterDirector SetCharacterBuilder(ICharacterBuilder characterBuilder)
        {
            this._characterBuilder = characterBuilder;
            return this;
        }

        public CharacterDirector(ICharacterBuilder characterBuilder)
        {
            this._characterBuilder = characterBuilder;
        }

        public Character GetNamelessCharacter()
        {
            return this._characterBuilder
                .SetName("Nameless")
                .SetFaction("New Camp")
                .SetGuild("Mercenary")
                .SetMeleeWeapon("Urizel")
                .SetRangeWeapon("Oak Bow")
                .SetArmor("Improved Ore Armor")
                .GetCharacter();
        }

        public Character GetGomezCharacter()
        {
            return this._characterBuilder
                .SetName("Gomez")
                .SetFaction("Old Camp")
                .SetGuild("Ore Baron")
                .SetMeleeWeapon("Wrath of Innos")
                .SetRangeWeapon("None")
                .SetArmor("Gomez' Armor")
                .GetCharacter();
        }
    }
}
