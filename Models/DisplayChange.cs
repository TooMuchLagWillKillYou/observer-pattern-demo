using System;
using Interfaces;

namespace Models
{
    public class DisplayChange : IObserver
    {
        private readonly ISubject _subject;
        
        public DisplayChange(ISubject subject)
        {
            _subject = subject;
            _subject.Subscribe(this);
        }

        public void Update(string symbol, decimal price)
        {
            Console.WriteLine(String.Format("Observer has been notified. Price changed to {0} {1}", symbol, price));
        }
    }
}