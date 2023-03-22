using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _enemy = new Character();

        private void _reset()
        {
            this._enemy = new Character();
        }

        public EnemyBuilder()
        {
            this._reset();
        }

        public ICharacterBuilder SetName(string name)
        {
            this._enemy.Name = name;
            return this;
        }

        public ICharacterBuilder SetFaction(string faction)
        {
            this._enemy.Faction = faction;
            return this;
        }

        public ICharacterBuilder SetGuild(string guild)
        {
            this._enemy.Guild = guild;
            return this;
        }

        public ICharacterBuilder SetMeleeWeapon(string meleeWeapon)
        {
            this._enemy.MeleeWeapon = meleeWeapon;
            return this;
        }

        public ICharacterBuilder SetRangeWeapon(string rangeWeapon)
        {
            this._enemy.RangeWeapon = rangeWeapon;
            return this;
        }

        public ICharacterBuilder SetArmor(string armor)
        {
            this._enemy.Armor = armor;
            return this;
        }

        public Character GetCharacter()
        {
            Character hero = this._enemy;
            this._reset();
            return hero;
        }
    }
}
