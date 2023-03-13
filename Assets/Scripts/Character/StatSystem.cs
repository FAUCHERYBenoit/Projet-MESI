using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace character.stat
{
    public class StatSystem
    {
        public StatSystem(List<Stat> characterStats)
        {
            this.characterStats = new List<Stat>();
            if (characterStats != null)
            {
                characterStats.ForEach(s =>
                {
                    this.characterStats.Add(new Stat(s.StatTypes, s.Amount, s.MaxAmount));
                });

            }
        }

        /// <summary>
        /// A stat container for each character stats 
        /// </summary>
        public List<Stat> characterStats;

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

    [Serializable]
    public class Stat
    {
        public Stat(StatTypes statTypes, float amount, float maxAmount = 150)
        {
            this.statTypes = statTypes;
            this.amount = amount;
            if (amount > maxAmount)
            {
                this.maxAmount = amount;
            }
            else
            {
                this.maxAmount = maxAmount;
            }
        }

        [SerializeField] private StatTypes statTypes;
        public StatTypes StatTypes { get { return statTypes; } }
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
        }
    }
}

