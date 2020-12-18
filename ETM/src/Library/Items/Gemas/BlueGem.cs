namespace Library
{
    public class BlueGem : IGem
    {
        public int AttackValue
        {
            get
            {
                return 100;
            }
        }
        public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        private string desc = "BlueGem";
    }
}