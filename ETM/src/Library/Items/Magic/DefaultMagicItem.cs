namespace Library
{
    public class DefaultMagicItem : IMagicItem
    {
        public int AttackValue 
        {
            get
            {
                return 5;
            } 
        }
        public int DefenseValue 
        {
            get
            {
                return 5;
            } 
        }
        public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        private string desc = "DefaultMagic";
    }
}