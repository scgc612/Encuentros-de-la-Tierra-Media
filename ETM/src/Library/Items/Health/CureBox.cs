namespace Library
{
    public class CureBox : IHealthItem
    {
        public int HealthValue
        {
            get
            {
                return 75;
            }
        }
        public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        private string desc = "CureBox";
    }
}