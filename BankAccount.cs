public class BankAccount {

    public string accountNumber {get; set;}
    // public decimal balance {get; set;}
    private decimal balance {get; set;}

    public decimal getBalance() {
        return balance;
    }

    public void makeDeposit(decimal newDeposit) {
        if (newDeposit < 0){
            // balance = balance;
            throw new Exception(" Deposit was under $0 dollars"); //we communicate the error in words
        } else {
        balance = balance + newDeposit;
        }
    }

    //constructor below
    public BankAccount() {
        accountNumber = "unknown";
        balance = 100.01m;
    }

    public BankAccount (string newAccountName) {
        accountNumber = newAccountName;
        balance = 100.01m;
    }

    public BankAccount(decimal startingBalance) : base() {
        accountNumber = "unknown";
        balance = 100.01m;

        if (startingBalance > 10000) {
            balance = startingBalance + 2000;
        } else {
            balance = startingBalance + 100.01m;
        }

    }

}