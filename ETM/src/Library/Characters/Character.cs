using System; 

namespace Library
{
    /// <summary>
    /// Se crea la Clase abstracta 
    /// </summary>
    public abstract class Character
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public Character(string name)
        {
            this.name=name;
        }
        public abstract void ReceiveAttack(int power);

        public abstract void Cure();

    }
    
}
