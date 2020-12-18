using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class PiedraEterna: IObserver
    {
        public int VillanosVencidos = 0;
        public ArrayList Heroes = new ArrayList()
        {
            "Caballero", 
            "Elfo", 
            "Gandalf", 
            "Enano"
        };
        
        public void Update(Character charAsesinado, Character charAsesino)
        {
            if (!Heroes.Contains(charAsesinado.Name))
            {
                VillanosVencidos+=1;
            }
            
        }
    }
        
}