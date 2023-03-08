using FactoryPattern.Interfaces;
using System;

namespace FactoryPattern.Implementation
{
    public class MBWay : IInterbankSystem
    {
        public void ExecutePayment()
        {
            Console.WriteLine("MBWay Payment");
        }
    }
}