namespace Library
{
    public class Armor : IDefenseItem
    {
        public int DefenseValue
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

        private string desc = "Armor";
    }
}