Console.WriteLine(" Welcome to the Bank");

BankAccount account = new BankAccount(-1);
// creating a new object from a class

// account.balance = 100;
try {
account.makeDeposit(-1);
} catch(Exception ex) {
    Console.WriteLine(ex.Message);
}

Console.WriteLine($" Your balance is: {account.getBalance()} "); 
Console.WriteLine($" Account Number: {account.accountNumber} ");