using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComplexTurnBased.GameClasses.SpecialEffects
{
    abstract class AbstractSpecialEffect
    {
        public readonly string name;

        abstract public void useSpecialEffect();
    }
}
