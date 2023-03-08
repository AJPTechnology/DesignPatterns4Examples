using System;

namespace Singleton.Implementation
{
    public class PaymentSingleton
    {
        private static PaymentSingleton? _instance;

        private PaymentSingleton() { }

        public static PaymentSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PaymentSingleton();
            }
            return _instance;
        }

        public void ExecutePayment()
        {
            Console.WriteLine("Executing Payment");
        }

    }
}
