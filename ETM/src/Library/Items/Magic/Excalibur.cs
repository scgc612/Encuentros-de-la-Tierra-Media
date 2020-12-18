namespace Library
{
    public class Excalibur : IMagicItem
    {
        public int AttackValue 
        {
            get
            {
                return 300;
            } 
        }

        public int DefenseValue
        {
            get
            {
                return 300;
            }
        }
        public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        private string desc = "Excalibur";
    }
}