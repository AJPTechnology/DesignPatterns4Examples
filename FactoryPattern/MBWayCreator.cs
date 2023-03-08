using FactoryPattern.Implementation;
using FactoryPattern.Interfaces;

namespace FactoryPattern.Creator
{
    public class MBWayCreator : Creator
    {
        public override IInterbankSystem InterbankSystemFactoyMethod()
        {
            return new MBWay();
        }
    }
}
