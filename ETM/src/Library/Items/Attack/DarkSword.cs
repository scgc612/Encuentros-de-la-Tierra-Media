using System.Collections.Generic;

namespace Library
{
    public class DarkSword : IAttackItem
    {
        public int AttackValue 
        {
            get
            {
                return this.attackValue;
            } 
            private set
            {
                foreach (IGem gema in Gemas)
                {
                    this.attackValue+=gema.AttackValue;
                }

            }
        }
        private int attackValue=0;
        public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        public List<IGem> Gemas = new List<IGem>();

        private string desc = "DarkSword";

        
    }
}