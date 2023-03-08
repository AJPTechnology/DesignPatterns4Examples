using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Implementation
{
    public class BankObserver : IObserver
    {
        public void Update(ILoginStateSubject subject)
        {
            LoginStateSubject? loginStateSubject = subject as LoginStateSubject;

            if (loginStateSubject == null)
            {
                return;
            }

            byte failedPasswordAttemps = loginStateSubject.FailedPasswordAttemps;

            if (failedPasswordAttemps >= 3)
            {
                Console.WriteLine("Schedule call from bank employee to customer to unlock account");
            }
        }
    }
}
