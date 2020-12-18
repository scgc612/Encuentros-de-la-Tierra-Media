namespace Library
{
    public class GoldenGem : IGem
    {
        public int AttackValue
        {
            get
            {
                return 150;
            }
        }
        public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        private string desc = "GoldenGem";
    }
}