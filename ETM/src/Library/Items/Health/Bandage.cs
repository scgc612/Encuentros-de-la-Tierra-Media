namespace Library
{
    public class Bandage : IHealthItem
    {
        public int HealthValue
        {
            get
            {
                return 20;
            }
        }
        public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        private string desc = "Bandage";
    }
}