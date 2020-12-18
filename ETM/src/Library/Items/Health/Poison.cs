namespace Library
{
    public class Poison : IHealthItem
    {
        public int HealthValue
        {
            get
            {
                return 25;
            }
        }
        public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        private string desc = "Poison";
    }
}