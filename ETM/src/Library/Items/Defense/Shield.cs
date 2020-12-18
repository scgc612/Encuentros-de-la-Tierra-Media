namespace Library
{
    public class Shield : IDefenseItem
    {
        public int DefenseValue
        {
            get
            {
                return 14;
            }
        }
        public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        private string desc = "Shield";
    }
}