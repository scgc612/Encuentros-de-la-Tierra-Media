using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class EncuentroCombate: IEncuentro, IObservable
    {
        public string Desc {get; set;}  
        List<Character> ListaHeroes {get; set;}
        List<Character> ListaVillanos {get; set;}

        public EncuentroCombate(List<Character> listaHeroes, List<Character> listaVillanos)
        {
            this.ListaHeroes=listaHeroes;
            this.ListaVillanos=listaVillanos;
            this.ListaPersonajesAsesinados= new List<Character>();
            this.ListaPersonajesGanadores = new List<Character>();
        }

        ArrayList resultadoCombate {get; set;}
        int ataquesVillanos {get; set;}
        int ataquesHeroes {get; set;}
        string Ganadores {get; set;}
        public List<Character> ListaPersonajesGanadores {get; set;}
        public List<Character> ListaPersonajesAsesinados {get; set;}


        public ArrayList Fight()
        {
            resultadoCombate = new ArrayList();
            while (ListaHeroes.Count>0 && ListaVillanos.Count>0)
            {
                ataquesVillanos=0;
                //cada villano ataca a un heroe
                foreach (Villano villano in ListaVillanos)
                {
                    ListaHeroes[ataquesVillanos].ReceiveAttack(villano.AttackValue);
                    if(ListaHeroes[ataquesVillanos].IsDead())
                    {
                        NotifyObservers(ListaHeroes[ataquesVillanos],villano);
                        resultadoCombate.Add($"{ListaHeroes[ataquesVillanos].Name} fue asesinado por {villano.Name}\n");
                        ListaPersonajesAsesinados.Add(ListaHeroes[ataquesVillanos]);
                        ListaHeroes.Remove(ListaHeroes[ataquesVillanos]);
                        
                    }
                    if (ataquesVillanos >= ListaHeroes.Count-1)
                    {
                        ataquesVillanos=0;
                    }
                    else
                    {
                        ataquesVillanos+= 1;
                    }

                    if (ListaHeroes.Count == 0 )
                    {
                        break;
                    }
                    

                } 
                
                //heroes atacan villanos
                ataquesHeroes=0;
                foreach (Heroe heroe in ListaHeroes)
                {
                    ListaVillanos[ataquesHeroes].ReceiveAttack(heroe.AttackValue);
                    if(ListaVillanos[ataquesHeroes].IsDead())
                    {
                        NotifyObservers(ListaVillanos[ataquesHeroes], heroe);
                        heroe.AddVP();
                        resultadoCombate.Add($"{ListaVillanos[ataquesHeroes].Name} fue asesinado por {heroe.Name}\n");
                        ListaPersonajesAsesinados.Add(ListaVillanos[ataquesHeroes]);
                        ListaVillanos.Remove(ListaVillanos[ataquesHeroes]);
                        
                    }
                    if (ataquesHeroes >= ListaVillanos.Count-1)
                    {
                        ataquesHeroes=0;
                    }
                    else
                    {
                        ataquesHeroes+= 1;
                    }
                    if (ListaVillanos.Count == 0)
                    {
                        break;
                    }
                } 
            }
            if (ListaHeroes.Count>0)
            {
                foreach(Heroe heroe in ListaHeroes)
                {
                    Ganadores+=heroe.Name+"\n";
                    ListaPersonajesGanadores.Add(heroe);
                }
            }
            else
            {
                foreach(Villano villano in ListaVillanos)
                {
                    Ganadores+=villano.Name+"\n";
                    ListaPersonajesGanadores.Add(villano);
                }
            }
            resultadoCombate.Add($"\nLos ganadores de este Encuentro de Combate fueron \n{Ganadores}");
            return resultadoCombate;

        }
        string resultsEncuentroCombate {get;set;}
        public string ShowResults()
        {
            foreach (string result in resultadoCombate)
            {
                resultsEncuentroCombate+= result;
            }
            return $"Los resultados de este Encuentro de Combate fueron:\n{resultsEncuentroCombate}";
        }

        List<IObserver> Observers = new List<IObserver>();

        public void Suscribe(IObserver observer)
        {
            if (! Observers.Contains(observer))
            {
                Observers.Add(observer);
            }
        }

        public void Unsuscribe(IObserver observer)
        {
            if (Observers.Contains(observer))
            {
                this.Observers.Remove(observer);
            }
        }
        public void NotifyObservers(Character char1, Character char2)
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update(char1, char2);
            }
        }
    }
}