namespace Library
{
    public class SilverGem : IGem
    {
        public int AttackValue
        {
            get
            {
                return 120;
            }
        }
        public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        private string desc = "SilverGem";
    }
}