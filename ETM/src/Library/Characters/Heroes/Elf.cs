namespace Library
{
    public class Elf:Heroe
    {
        private int health = 220;

         public Elf(string name,  IAttackItem attackItem, IDefenseItem defenseItem, IDefenseItem defenseItem2)
            : base (name, attackItem, defenseItem, defenseItem2)
        {
        }

        //public string Name { get; set; }

        public override int AttackValue
        {
            get
            {
                return AttackItem.AttackValue;
            }
        }

        public override int DefenseValue
        {
            get
            {
                return DefenseItem.DefenseValue + DefenseItem2.DefenseValue;
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
            this.Health = 220;
        }
        public override bool IsDead()
        {
            return this.Health == 0 ;
        }
    }
}