using Singleton.Implementation;

PaymentSingleton paymentSingleton = PaymentSingleton.GetInstance();
TransferSingleton transferSingleton = TransferSingleton.GetInstance();

Facade.Implementation.TransactionFacade transactionFacade = new Facade.Implementation.TransactionFacade(paymentSingleton, transferSingleton);

transactionFacade.ExecutePayment();
transactionFacade.ExecuteTransfer();