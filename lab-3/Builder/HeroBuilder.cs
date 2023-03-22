using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character _hero = new Character();

        private void _reset()
        {
            this._hero = new Character();
        }

        public HeroBuilder()
        {
            this._reset();
        }

        public ICharacterBuilder SetName(string name)
        {
            this._hero.Name = name;
            return this;
        }

        public ICharacterBuilder SetFaction(string faction)
        {
            this._hero.Faction = faction;
            return this;
        }

        public ICharacterBuilder SetGuild(string guild)
        {
            this._hero.Guild = guild;
            return this;
        }

        public ICharacterBuilder SetMeleeWeapon(string meleeWeapon)
        {
            this._hero.MeleeWeapon = meleeWeapon;
            return this;
        }

        public ICharacterBuilder SetRangeWeapon(string rangeWeapon)
        {
            this._hero.RangeWeapon = rangeWeapon;
            return this;
        }

        public ICharacterBuilder SetArmor(string armor)
        {
            this._hero.Armor = armor;
            return this;
        }

        public Character GetCharacter()
        {
            Character hero = this._hero;
            this._reset();
            return hero;
        }
    }
}
