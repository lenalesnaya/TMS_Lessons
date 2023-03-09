namespace Lessons.Lesson5Tasks
{
    internal class CreditCard
    {
        private string? accountId;
        private decimal currentBalance;


        public CreditCard(string accountId) : this(accountId, 0.0m) { }

        public CreditCard(string accountId, decimal initialBalance)
        {
            ValidateAccountId(accountId);
            currentBalance = initialBalance;
        }


        public void ShowInfo()
        {
            if (accountId == null)
            {
                Console.WriteLine("\nYou didn`t enter a valid account Id.");
                return;
            }

            Console.WriteLine($"\nAccount Id: {accountId.ToUpper()}");
            Console.WriteLine($"The current balance: {currentBalance: 0.00}$");
        }

        public void ReplenishBalance(decimal sum)
        {
            if (accountId == null)
            {
                Console.WriteLine("\nYou didn`t enter a valid account Id.");
                return;
            }

            currentBalance += sum;
            Console.WriteLine($"\nThe balance replenished by {sum: 0.00}$");
            Console.WriteLine($"The current balance: {currentBalance: 0.00}$");
        }

        public void WithdrawSum(decimal sum)
        {
            if (accountId == null)
            {
                Console.WriteLine("\nYou didn`t enter a valid account Id.");
                return;
            }

            if (currentBalance >= sum)
            {
                currentBalance -= sum;
                Console.WriteLine($"\nDebited from the account: {sum: 0.00}$");
                Console.WriteLine($"The current balance: {currentBalance: 0.00}$");
            }
            else
            {
                Console.WriteLine("\nThere aren`t enough funds on the account");
                Console.WriteLine($"The current balance: {currentBalance: 0.00}$");
            }
        }


        private void ValidateAccountId(string accountId)
        {
            if (accountId.Length == 12)
            {
                this.accountId = accountId;
            }
            else
            {
                this.accountId = null;
                Console.WriteLine("\nError, invalid account Id.");
            }
        }
    }
}