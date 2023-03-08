using System;

namespace Singleton.Implementation
{
    public class TransferSingleton
    {
        private static TransferSingleton? _instance;

        private TransferSingleton() { }

        public static TransferSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TransferSingleton();
            }
            return _instance;
        }

        public void ExecuteTransfer()
        {
            Console.WriteLine("Executing Transfer");
        }
    }
}

