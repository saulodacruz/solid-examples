namespace SOLID.L
{
    public abstract class Account
    {
        public abstract void GetBalance(int id);
    }

    public class SavingsAccount : Account
    {
        public override void GetBalance(int id)
        {
            // Get balance for savings account
        }
    }

    public class CheckingAccount : Account
    {
        public override void GetBalance(int id)
        {
            // Get balance for checking account
        }
    }

    class Program
    {
        public void Run()
        {
            Account savingsAccount = new SavingsAccount();
            savingsAccount.GetBalance(id: 1);

            Account checkingAccount = new CheckingAccount();
            checkingAccount.GetBalance(id: 2);
        }
    }
}
