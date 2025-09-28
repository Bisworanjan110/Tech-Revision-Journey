namespace BankAccountSystem
{
    class BankAccount
    {
        private double balance { get; set; }
        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                this.balance = this.balance + amount;
                Console.WriteLine("Successful deposit.");
            }
            else
            {
                Console.WriteLine("Enter correct amount");
            }
        }
        public void Withdraw(double amount)
        {
            if(this.balance >= amount)
            {
                this.balance -= amount;
                Console.WriteLine("Successful Withdrawl");
            }
            else
            {
                Console.WriteLine("Insufficient amount");
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine("Your current balance is: " + this.balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(10000);
            bankAccount.Deposit(0);
            bankAccount.Withdraw(15000);
            bankAccount.ShowBalance();
        }
    }
}
