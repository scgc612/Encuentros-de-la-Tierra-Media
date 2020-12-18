namespace Library
{
    public class DefaultDefenseItem : IDefenseItem
    {
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

        private string desc = "DefaultDefense";
    }
}