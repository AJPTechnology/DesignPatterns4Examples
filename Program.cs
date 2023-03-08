using Singleton.Implementation;

PaymentSingleton paymentSingleton = PaymentSingleton.GetInstance();
TransferSingleton transferSingleton = TransferSingleton.GetInstance();

paymentSingleton.ExecutePayment();
transferSingleton.ExecuteTransfer();
