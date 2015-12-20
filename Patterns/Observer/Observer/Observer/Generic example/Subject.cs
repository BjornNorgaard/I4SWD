using System;
using System.Collections.Generic;

namespace Observer
{
    public abstract class Subject
    {
        List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Nofity()
        {
            foreach (Observer observer in _observers)
            {
                observer.Update();
            }
            Console.WriteLine("");
        }
    }
}