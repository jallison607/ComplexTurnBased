using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComplexTurnBased.GameClasses.SpecialEffects;

namespace ComplexTurnBased.GameClasses
{
    public class Effect
    {
        private string name;
        private string effectElement;
        private string effectType;
        private int effectValue;
        private int effectDuration;
        private bool hitsFoes;
        private int numberEffected;
        private AbstractSpecialEffect specialEffect;

    }
}
