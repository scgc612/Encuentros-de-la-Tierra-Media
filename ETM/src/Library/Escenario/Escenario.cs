using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    /// <summary>
    /// Clase que conoce los personajes que se encuentran en el escenario
    /// y los encuentros que se dan el mismo 
    /// </summary>
    public class Escenario
    {
        public string Historia{get; set;}
        public List<Character> PersonajesEscenario{get; set;}
        public List<IItem> ItemsEscenario{get; set;}
        public ItemFactory ItemFactory{get; set;}
        public List<Character> HeroesForCombat{get; set;}
        public List<Character> VillanosForCombat{get; set;}
        public List<Character> PersonajesForIntercambio{get; set;}
        public CharFactory CharFactory {get; private set;}
        public List<IEncuentro> ListaEncuentros {get; set;}

        public IItem ItemForIntercambio {get; set;}
        public Escenario ()
        {
            this.CharFactory = new CharFactory();
            this.PersonajesEscenario=new List<Character>();
            this.ItemFactory= new ItemFactory();
            this.ItemsEscenario= new List<IItem>();
            this.HeroesForCombat= new List<Character>();
            this.PersonajesForIntercambio=new List<Character>();
            this.VillanosForCombat=new List<Character>();
            this.ListaEncuentros = new List<IEncuentro>();
            this.Historia= "";

        }

        //se aplica patrón Creador ya que cunple con la condición que Escenario 
        //usa de forma cercana objetos de EncuentroCombate
        public void CrearEncuentroCombate()
        {
            EncuentroCombate encuentroCombate = new EncuentroCombate(HeroesForCombat, VillanosForCombat);
            encuentroCombate.Suscribe(new TorreCaidos());
            encuentroCombate.Fight();
            foreach(Character personaje in encuentroCombate.ListaPersonajesGanadores)
            {
                PersonajesEscenario.Add(personaje);
            }
            ListaEncuentros.Add(encuentroCombate);
        }
        public void CrearEncuentroIntercambio()
        {
            try
            {
                EncuentroIntercambio encuentroIntercambio = new EncuentroIntercambio(PersonajesForIntercambio[0], PersonajesForIntercambio[1]);
                encuentroIntercambio.Intercambiar(ItemForIntercambio);
                PersonajesEscenario.Add(PersonajesForIntercambio[0]);
                PersonajesForIntercambio.Remove(PersonajesForIntercambio[0]);
                PersonajesEscenario.Add(PersonajesForIntercambio[0]);
                PersonajesForIntercambio.Remove(PersonajesForIntercambio[0]);
                ListaEncuentros.Add(encuentroIntercambio);
            }
            catch (System.NullReferenceException)
            {
                ;
            }
            
        }

        public void AddCharacter(Character character)
        {
            PersonajesEscenario.Add(character);

        }
        public void AddItem(IItem item)
        {
            ItemsEscenario.Add(item);

        }
        public void AddHeroeForCombat(string tipo)
        {
            foreach (Character personaje in PersonajesEscenario)
            {
                if (personaje.Name == tipo)
                {
                    HeroesForCombat.Add(personaje);
                    PersonajesEscenario.Remove(personaje);
                    break;
                }
            }
            
        }
        public void AddVillanoForCombat(string tipo)
        {
            foreach (Character personaje in PersonajesEscenario)
            {
                if (personaje.Name == tipo)
                {
                    VillanosForCombat.Add(personaje);
                    PersonajesEscenario.Remove(personaje);
                    break;
                }
            }
        }
        public void AddPersonajeForIntercambio(string tipo)
        {
            foreach (Character personaje in PersonajesEscenario)
            {
                if (personaje.Name == tipo && PersonajesForIntercambio.Count<3)
                {
                    PersonajesForIntercambio.Add(personaje);
                    PersonajesEscenario.Remove(personaje);
                    break;
                }
            }
        }
        public void AddItemForIntercambio(string tipo)
        {
            foreach (IItem item in ItemsEscenario)
            {
                if (item.Desc == tipo)
                {
                    ItemForIntercambio=item;
                    ItemsEscenario.Remove(item);
                    break;
                }
            }
        }
        public string EstadoEscenario()
        {
            List<Character> heroes = new List<Character>();
            List<Character> villanos = new List<Character>();
            foreach (Character personaje in PersonajesEscenario)
            {
                if (this.CharFactory.ListaNombresHeroes.Contains(personaje.Name))
                {
                    heroes.Add(personaje);
                }
                else if (this.CharFactory.ListaNombresVillanos.Contains(personaje.Name))
                {
                    villanos.Add(personaje);
                }
            }

            if (heroes.Count>0 && villanos.Count>0)
            {
                return "Hay villanos y heroes en la Tierra Media, nadie se ha apoderado de ella aún";
            }
            else if (heroes.Count>0)
            {
                return $"Los Heroes se han apoderado de la Tierra Media";
            }
            else if (villanos.Count>0)
            {
                return $"Los Villanos se han apoderado de la Tierra Media";
            }
            return "";
        }
        public string FinalizarEscenario()
        {
            string resultadoEscenario="";
            foreach(IEncuentro encuentro in ListaEncuentros)
            {
                resultadoEscenario=encuentro.ShowResults()+"\n";
            }
            ListaEncuentros=new List<IEncuentro>();
            Historia+=resultadoEscenario+EstadoEscenario();
            return resultadoEscenario+EstadoEscenario();
        }

        

    }
}