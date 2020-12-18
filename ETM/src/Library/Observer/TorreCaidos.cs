using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class TorreCaidos: IObserver, IObservable
    {
        List<IObserver> Observers = new List<IObserver>();
        public void Update(Character charAsesinado, Character charAsesino)
        {
            NotifyObservers(charAsesinado,charAsesino);
        }
        public void NotifyObservers(Character charAsesinado, Character charAsesino)
        {
            Observers.Add(new ArbolMilDias());
            Observers.Add(new ArbolMilDias());
            foreach (IObserver observer in Observers)
            {
                observer.Update(charAsesinado,charAsesino);
            }
        }

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

       
    }
        
}