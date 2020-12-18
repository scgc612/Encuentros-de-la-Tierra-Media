namespace Library
{
    public class DefaultSpell : IMagicItem
    {
        public int AttackValue
        {
            get
            {
                return 0;
            }
        }

        public int DefenseValue
        {
            get
            {
                return 0;
            }
        }

        public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        private string desc = "DefaultSpell";
    }
}