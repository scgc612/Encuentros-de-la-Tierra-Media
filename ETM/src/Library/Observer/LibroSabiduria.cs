using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class LibroSabiduria: IObserver
    {
        public ArrayList resultadoEnfrentamientos = new ArrayList();
        
        public void Update(Character charAsesinado, Character charAsesino)
        {
            resultadoEnfrentamientos.Add($"{charAsesinado.Name} fue derrotado por {charAsesino}");
        }
    }
        
}