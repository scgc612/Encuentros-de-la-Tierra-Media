namespace Library
{
    public class Helmet : IDefenseItem
    {
        public int DefenseValue
        {
            get
            {
                return 18;
            }
        }
        public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        private string desc = "Helmet";
    }
}