using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

namespace character
{
    public abstract class AbstractCharacterStats : ScriptableObject
    {
        public List<Stat> characterStats = new List<Stat>()
        {
            new Stat(StatTypes.Life, 0),
            new Stat(StatTypes.Stamina, 0),
            new Stat(StatTypes.Damage, 0),
            new Stat(StatTypes.Speed, 0),
            new Stat(StatTypes.Experience, 0),
            new Stat(StatTypes.FOV, 0)
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
            [Header("Type")]
            [SerializeField] private StatTypes statTypes;
            public StatTypes StatTypes { get { return statTypes; } }

            [Header("Amount")]
            [SerializeField] private float amount;
            public float Amount { get { return amount; } }
            [SerializeField] private float maxAmount;
            public float MaxAmount { get { return maxAmount; } }

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
                if (amount < 0)
                {
                    amount = 0;
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
            Stat stat = characterStats.Where(s => s.StatTypes == statTypes).FirstOrDefault();
            stat.AddOrRemove(amount);
        }

        /// <summary>
        /// This method allows to set the stat of the character
        /// </summary>
        /// <param name="statTypes"> the type of the stat</param>
        /// <param name="amount">Amount to ass or remove </param>
        public virtual void SetStatAtValue(StatTypes statTypes, float amount)
        {
            Stat stat = characterStats.Where(s => s.StatTypes == statTypes).FirstOrDefault();
            stat.SetValue(amount);
        }

        /// <summary>
        /// Returns the value of a character stat
        /// </summary>
        /// <param name="statTypes"></param>
        /// <returns></returns>
        public virtual float GetStatValue(StatTypes statTypes)
        {
            return characterStats.Where(s => s.StatTypes == statTypes).FirstOrDefault().Amount;
        }
    }

    public enum StatTypes
    {
        Life,
        Speed,
        Stamina,
        Damage,
        Experience,
        FOV,
    }
}

