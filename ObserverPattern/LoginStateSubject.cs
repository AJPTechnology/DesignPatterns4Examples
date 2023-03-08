using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Implementation
{
    public class LoginStateSubject : ILoginStateSubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public byte FailedPasswordAttemps { get; private set; }

        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void InputFailedPassword()
        {
            FailedPasswordAttemps++;
            this.Notify();
        }

    }
}

