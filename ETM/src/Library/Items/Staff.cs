namespace Library
{
    public class Staff : IAttackItem, IDefenseItem , IItem
    {
        public int AttackValue 
        {
            get
            {
                return 100;
            } 
        }

        public int DefenseValue
        {
            get
            {
                return 100;
            }
        }

        public string Desc
        {
            get
            {
                return this.desc;
            }

        }

        private string desc = "Staff";
    }
}