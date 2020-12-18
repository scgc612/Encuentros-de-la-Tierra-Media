namespace Library
{
    public interface IObservable
    {

        void Suscribe(IObserver observer);

        void Unsuscribe(IObserver observer);

    }
}