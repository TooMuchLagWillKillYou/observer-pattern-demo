namespace Interfaces
{
    public interface IObserver
    {
        public void Update(string symbol, decimal price);
    }
}