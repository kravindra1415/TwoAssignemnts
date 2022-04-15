// See https://aka.ms/new-console-template for more information


abstract class Account
{
    public int accountNumber;
    public int AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
    public Customer customerObj;

    public Customer CustomerObj { get { return customerObj; } set { customerObj = value; } }

    public double balance;

    public Account(int accountNumber, Customer customerObj, double balance)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
        this.customerObj = customerObj;
    }

    public double Balance { get { return balance; } set { balance = value; } }



    abstract public bool withdraw(double amount);

}

