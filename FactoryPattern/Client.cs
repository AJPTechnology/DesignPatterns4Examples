namespace FactoryPattern.Creator
{
    public class Client
    {
        public void Main()
        {
            ClientCode(new MBWayCreator());

            ClientCode(new MultiBancoCreator());
        }

        public void ClientCode(Creator creator)
        {
            creator.ExecutePayment();
        }

    }
}
