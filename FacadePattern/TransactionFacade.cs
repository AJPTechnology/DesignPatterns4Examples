using Singleton.Implementation;

namespace Facade.Implementation
{
    public class TransactionFacade
    {
        protected PaymentSingleton _paymentSingleton;
        protected TransferSingleton _transferSingleton;

        public TransactionFacade(PaymentSingleton paymentSingleton, TransferSingleton transferSingleton)
        {
            _paymentSingleton = paymentSingleton;
            _transferSingleton = transferSingleton;
        }

        public void ExecutePayment()
        {
            _paymentSingleton.ExecutePayment();
        }

        public void ExecuteTransfer()
        {
            _transferSingleton.ExecuteTransfer();
        }

    }
}

