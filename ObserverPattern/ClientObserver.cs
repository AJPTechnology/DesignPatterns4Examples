using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Implementation
{
    public class ClientObserver : IObserver
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
                Console.WriteLine("Send PushNotification informing that Internet Banking account is locked");
            }
            else if (failedPasswordAttemps == 2)
            {
                Console.WriteLine("Send PushNotification informing that client has 1 remaining attempt");
            }
        }
    }
}
