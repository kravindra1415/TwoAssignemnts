// See https://aka.ms/new-console-template for more information


class SavingsAccount : Account
{
    private double minimumBalance;

    public double MinimumBalance { get { return minimumBalance; } }

    public SavingsAccount(int accountNumber, Customer customerObj, double balance, double minimumBalance) : base(accountNumber, customerObj, balance)
    {
        this.minimumBalance = minimumBalance;
    }

    public override bool withdraw(double amount)
    {
        if ((balance - amount) > minimumBalance)
        {
            balance = (balance - amount);
            return true;
        }
        else
            return false;
    }
}

