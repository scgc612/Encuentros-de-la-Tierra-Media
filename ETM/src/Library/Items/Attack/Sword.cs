namespace Library
{
    public class Sword : IAttackItem
    {
        public int AttackValue 
        {
            get
            {
                return 130;
            } 
        }
        public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        private string desc = "Sword";
    }
}