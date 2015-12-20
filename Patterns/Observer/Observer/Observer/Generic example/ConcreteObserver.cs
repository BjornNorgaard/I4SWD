using System;

namespace Observer
{
    public class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;
        ConcreteSubject _subject;

        public ConcreteObserver(string name, ConcreteSubject subject)
        {
            _name = name;
            _subject = subject;
        }

        public override void Update()
        {
            _observerState = _subject.State;
            Console.WriteLine("Observer " + _name + "'s new state is " + _observerState);
        }
    }
}