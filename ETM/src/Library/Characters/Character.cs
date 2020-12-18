using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    /// <summary>
    /// Se crea la Clase abstracta 
    /// </summary>
    public abstract class Character
    {
        public string Name {get; private set;}
        
        public Character(string name)
        {
            this.Name=name;
            this.Items = new List<IItem>();
        }


        public List<IItem> Items { get; set; }
        public string ItemsString="";        
        public string AddItem(IItem item)
        {
            if (Items.Count < 5)
            {
                this.Items.Add(item);
                return $"{this.Name} aquirió {item}";
            }
            else
            {
                return "Ya tiene cuatro Items, debe dejar un Item";
            }
            
        }
        public string ShowItems()
        {
            foreach (IItem I in Items)
            {
                ItemsString+=I.ToString()+"\n";
            }
            return ItemsString;
        }
        public void DelItem(IItem item)
        {
            foreach (IItem I in Items)
            {
                if (I == item)
                {
                    Items.Remove(I);
                    break;
                }
            }
        }
        public void ComponerItem(VaraDeAsclepio vara, IMagicItem itemMagico)
        {
            if(Items.Contains(itemMagico) && Items.Contains(vara))
            {
                vara.ItemMagico=itemMagico;
                Items.Remove(itemMagico);
            }
            

        }

        public abstract void ReceiveAttack(int power);

        public abstract void Cure();
        public abstract bool IsDead();
    }
    
}
