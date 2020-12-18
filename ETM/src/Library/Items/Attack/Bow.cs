namespace Library
{
    public class Bow : IAttackItem
    {
        public int AttackValue 
        {
            get
            {
                return 110;
            } 
        }
    public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        private string desc = "Bow";
    }
    
}