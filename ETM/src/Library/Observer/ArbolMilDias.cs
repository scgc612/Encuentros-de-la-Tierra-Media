using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class ArbolMilDias: IObserver
    {
        public ArrayList HeroesVencidos = new ArrayList();
        public ArrayList Heroes = new ArrayList()
        {
            "Caballero", 
            "Elfo", 
            "Gandalf", 
            "Enano"
        };
        
        public void Update(Character charAsesinado, Character charAsesino)
        {
            if (Heroes.Contains(charAsesinado.Name))
            {
                HeroesVencidos.Add(charAsesinado.Name);
            }
            
        }
    }
        
}