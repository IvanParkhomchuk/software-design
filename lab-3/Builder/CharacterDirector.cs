using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CharacterDirector
    {
        private ICharacterBuilder _heroBuilder;
        private ICharacterBuilder _enemyBuilder;

        public CharacterDirector SetHeroBuilder(HeroBuilder heroBuilder)
        {
            this._heroBuilder = heroBuilder;
            return this;
        }

        public CharacterDirector SetEnemyBuilder(EnemyBuilder enemyBuilder)
        {
            this._enemyBuilder = enemyBuilder;
            return this;
        }

        public CharacterDirector(HeroBuilder heroBuilder)
        {
            this._heroBuilder = heroBuilder;
        }

        public CharacterDirector(EnemyBuilder enemyBuilder)
        {
            this._enemyBuilder = enemyBuilder;
        }

        public Character GetNamelessCharacter()
        {
            return this._heroBuilder
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
            return this._enemyBuilder
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
