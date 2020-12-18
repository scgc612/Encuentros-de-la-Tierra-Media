using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public abstract class Heroe:Character
    {

        //Los héroes podrán contar con dos elementos de defensa y uno de ataque
         public Heroe(string name, IAttackItem attackItem, IDefenseItem defenseItem, IDefenseItem defenseItem2)
            : base (name)
        {
            this.AttackItem=attackItem;
            this.DefenseItem=defenseItem;
            this.DefenseItem2=defenseItem2;
            this.VictoryPoints=0;
        }
        
        //la variable item1 es transitoria, se utiliza para almacenar un item mientras 
        //se cambia el item que va a utilizar el personaje para poder almacenarlo
        //dentro de sus pertenencias
        public IItem item1{ get; set; }
        public string UseAttackItem(IAttackItem item)
        {
            foreach (IItem I in this.Items)
            {
                if (I == item)
                {
                    item1= this.AttackItem;
                    this.AttackItem=item;
                    Items.Remove(item);
                    Items.Add(item1);
                    return $"{this.Name} ahora está usando {item}";
                }
                else 
                {
                    return "Este personaje no contiene este item";
                }
            }
            return "";
            
        }
        public string UseDefenseItem(IDefenseItem item)
        {
            foreach (IItem I in this.Items)
            {
                if (I == item)
                {
                    item1= this.DefenseItem;
                    this.DefenseItem=item;
                    Items.Remove(item);
                    Items.Add(item1);
                    return $"{this.Name} ahora está usando {item}";
                }
                else 
                {
                    return "Este personaje no contiene este item";
                }
            }
            return "";
            
        }
        
        public void AddVP()
        {
            this.VictoryPoints+=1;
            if (this.VictoryPoints>=5)
            {
                this.Cure();
                this.VictoryPoints=0;
            }
        }
        

        
        //public string Name { get; set; }

        public IAttackItem AttackItem { get; set; }
        public IDefenseItem DefenseItem{ get; set; }
        public IDefenseItem DefenseItem2{ get; set; }
        public IHealthItem HealthItem{ get; set; }

        public int VictoryPoints{ get; set; }

        //por Expert la característica de Curarse cuando tenga 5VP
        //es responsabilidad de si mismo ya que es el experto en 
        //conocer este atributo propio

        public void cureVP()
        {
            
        }

        public abstract int AttackValue{ get;}
        public abstract int DefenseValue{ get;}


    }
}