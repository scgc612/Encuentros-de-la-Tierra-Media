using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class EncuentroIntercambio: IEncuentro
    {
        public string Desc {get; set;}
        public Character Char1 {get; set;}
        public Character Char2 {get; set;}
        public EncuentroIntercambio(Character char1, Character char2)
        {
            this.Char1 = char1;
            this.Char2 = char2;
        }
        public ArrayList Intercambiar( IItem itemChar1)
        {
        //    if (Char1.Items.Contains(itemChar1))
        //    {
        //        Char1.Items.Remove(itemChar1);
        //        Char2.Items.Add(itemChar1);
               
        //    }
        //    else
        //    {
        //        resultadoIntercambio.Add($"{Char1.Name} no contiene el elemento {itemChar1.Desc}");
        //    }
           resultadoIntercambio.Add($"{Char1.Name} ha transferido {itemChar1.Desc} a {Char2.Name}");
           return resultadoIntercambio;

        }
        private ArrayList resultadoIntercambio = new ArrayList();
        string resultsEncuentroIntercambio {get;set;}
        public string ShowResults()
        {
            foreach (string result in resultadoIntercambio)
            {
                resultsEncuentroIntercambio+= result+"\n";
            }
            return $"El resultado del Encuentro de Intercambio entre {this.Char1.Name} y {this.Char2.Name} fue:\n{resultsEncuentroIntercambio}";
        }

    }
}