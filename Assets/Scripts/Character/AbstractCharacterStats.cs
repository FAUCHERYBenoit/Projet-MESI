using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

namespace character.stats
{
    public abstract class AbstractCharacterStats : ScriptableObject
    {
        public List<Stat> characterStats = new List<Stat>()
        {
            new Stat(StatTypes.Life, 0),
            new Stat(StatTypes.Stamina, 0),
        };

        /// <summary>
        /// A stat container for each character stats 
        /// </summary>
        [Serializable]
        public class Stat
        {
            public Stat(StatTypes statTypes, float amount)
            {
                this.statTypes = statTypes;
                this.amount = amount;
            }

            public StatTypes statTypes { get; private set; }
            public float amount { get; private set; }
            public float maxAmount { get; private set; }
            public void AddOrRemove(float amount)
            {
                this.amount += amount;
                CheckClamp();
            }

            public void SetValue(float amount)
            {
                this.amount = amount;
                CheckClamp();
            }

            private void CheckClamp()
            {
                if (amount > maxAmount)
                {
                    amount = maxAmount;
                }
            }
        }

        /// <summary>
        /// This method allows to give bonus or minus to a stat value
        /// </summary>
        /// <param name="statTypes"> the type of the stat</param>
        /// <param name="amount">Amount to ass or remove </param>
        public virtual void AddOrRemoveStat(StatTypes statTypes, float amount)
        {
            Stat stat = characterStats.Where(s => s.statTypes == statTypes).FirstOrDefault();
            stat.AddOrRemove(amount);
        }

        /// <summary>
        /// This method allows to set the stat of the character
        /// </summary>
        /// <param name="statTypes"> the type of the stat</param>
        /// <param name="amount">Amount to ass or remove </param>
        public virtual void SetStatAtValue(StatTypes statTypes, float amount)
        {
            Stat stat = characterStats.Where(s => s.statTypes == statTypes).FirstOrDefault();
            stat.SetValue(amount);
        }
    }

    public enum StatTypes
    {
        Life,
        Stamina
    }
}

