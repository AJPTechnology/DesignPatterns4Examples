using FactoryPattern.Interfaces;
using System;

namespace FactoryPattern.Implementation
{
    public class MultiBanco : IInterbankSystem
    {
        public void ExecutePayment()
        {
            Console.WriteLine("MultiBanco Payment");
        }
    }
}
