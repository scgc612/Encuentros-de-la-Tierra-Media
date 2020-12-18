using System.Collections.Generic;

namespace Library
{
    public class SpellsBook : IMagicItem
    {
        public Spell[] Spells { get; set; }
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                try
                {
                    foreach (Spell spell in this.Spells)
                    {
                        value += spell.AttackValue;
                    }
                }
                catch (System.NullReferenceException)
                {
                    ;
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                try
                {
                    foreach (Spell spell in this.Spells)
                    {
                        value += spell.DefenseValue;
                    }
                }
                catch (System.NullReferenceException)
                {
                    ;
                }
                return value;
            }
        }

        public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        private string desc = "SpellsBook";
    }
}