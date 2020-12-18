using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Library
{
    /// <summary>
    /// Clase que implementa interfaz para crear Escenario 
    /// </summary>
    public class EscribirEscenario:IContarHistoria
    {
        //se puede modificar en donde quiero que lo escriba
        public string FileDir {get;set;}

        public EscribirEscenario(string fileDir)
        {
            this.FileDir=fileDir;
        }
        public void ContarHistoria(Escenario escenario)
        {
            File.WriteAllText(FileDir, escenario.Historia);
        }
        
    }
}