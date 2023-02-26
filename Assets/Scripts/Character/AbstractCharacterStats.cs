using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

namespace character.stat
{
    public abstract class AbstractCharacterStats : ScriptableObject
    {
        public List<Stat> characterStats = new List<Stat>()
        {
            new Stat(StatTypes.Life, 100, 100),
            new Stat(StatTypes.Stamina, 100, 100),
        };
    }

    public enum StatTypes
    {
        Life,
        Stamina
    }
}

