using FactoryPattern.Implementation;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Creator
{
    public class MultiBancoCreator : Creator
    {
        public override IInterbankSystem InterbankSystemFactoyMethod()
        {
            return new MultiBanco();
        }
    }
}

