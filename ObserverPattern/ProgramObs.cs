using ObserverPattern.Implementation;

LoginStateSubject loginStateSubject = new LoginStateSubject();

ClientObserver clientObserver = new ClientObserver();
loginStateSubject.Attach(clientObserver);

BankObserver bankObserver = new BankObserver();
loginStateSubject.Attach(bankObserver);

loginStateSubject.InputFailedPassword();
loginStateSubject.InputFailedPassword();
loginStateSubject.InputFailedPassword();