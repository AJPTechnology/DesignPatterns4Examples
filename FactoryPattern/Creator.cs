using FactoryPattern.Interfaces;

namespace FactoryPattern.Creator
{
    public abstract class Creator
    {
        public abstract IInterbankSystem InterbankSystemFactoyMethod();

        public void ExecutePayment()
        {
            IInterbankSystem? intebankSystem = InterbankSystemFactoyMethod();

            intebankSystem.ExecutePayment();
        }
    }
}
