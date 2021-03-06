namespace Library
{
    public class DarkWizard:Villano
    {
        private int health = 100;

         public DarkWizard(string name,  IAttackItem attackItem, IDefenseItem defenseItem, IMagicItem magicItem)
            : base (name, attackItem, defenseItem)
        {
            this.MagicItem = magicItem;
        }

        //public string Name { get; set; }
        public IMagicItem MagicItem { get; set; }

        public override int AttackValue
        {
            get
            {
                return AttackItem.AttackValue+MagicItem.AttackValue;
            }
        }

        public override int DefenseValue
        {
            get
            {
                return DefenseItem.DefenseValue+MagicItem.DefenseValue;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }
        public string UseMagicItem(IMagicItem item)
        {
            foreach (IItem I in this.Items)
            {
                if (I == item)
                {
                    item1= this.MagicItem;
                    this.MagicItem=item;
                    Items.Remove(item);
                    Items.Add(item1);
                    return $"{this.Name} ahora está usando {item}";
                }
                else 
                {
                    return "Este personaje no contiene este item";
                }
            }
            return "";
            
        }
        public string UseHealthItem(IHealthItem item)
        {
            foreach (IItem I in this.Items)
            {
                if (I == item)
                {
                    this.Health+=item.HealthValue;
                    Items.Remove(item);
                    return $"{this.Name} ahora tiene {this.Health} de vida";
                }
                else 
                {
                    return "Este personaje no contiene este item";
                }
            }
            return "";
            
        }

        public override void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public override void Cure()
        {
            this.Health = 100;
        }
        public override bool IsDead()
        {
            return this.Health == 0 ;
        }
    }
}