using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComplexTurnBased.GameClasses.Entity
{
    abstract class Entity
    {
        private string name;
        //private Race characterRace;

        //Stats
        private int _strength;
        private int _dexterity;
        private int _magi;
        private int _constitution;
        private int _level;

        //Combat
        private int MaxHP;
        private int MaxMana;
        private int damageTaken;
        private int manaUsed;

        abstract public override void takeDamage(int damage, string type);
        abstract public override bool isAlive();

    }
}
