namespace Library
{
    /// <summary>
    /// Clase cuya función es constituir objetos que en su construcción
    /// no quieramos que tengan valor de ataque
    /// </summary>
    public class DefaultAttackItem : IAttackItem
    {
        public int AttackValue 
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

        private string desc = "DefaultAttack";
    }
}