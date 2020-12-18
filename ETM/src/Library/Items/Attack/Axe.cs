namespace Library
{
    public class Axe : IAttackItem
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

        private string desc = "Axe";
        

        
    }
}