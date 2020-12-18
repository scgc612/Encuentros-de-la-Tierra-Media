namespace Library
{
    public class VaraDeAsclepio : IAttackItem, IDefenseItem , IItem
    {
        public int AttackValue 
        {
            get
            {
                return ItemMagico.AttackValue;
            } 
        }
        public int DefenseValue
        {
            get
            {
                return ItemMagico.DefenseValue;
            }
        }
        public string Desc
        {
            get
            {
                return this.desc;
            }

        }
        public IMagicItem ItemMagico = new DefaultMagicItem();

        private string desc = "VaraDeAsclepio";
    }
}