namespace Library
{
    public class Spell : IMagicItem
    {
        public int AttackValue
        {
            get
            {
                return 70;
            }
        }

        public int DefenseValue
        {
            get
            {
                return 70;
            }
        }

        public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        private string desc = "Spell";
    }
}