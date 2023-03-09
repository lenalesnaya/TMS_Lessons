namespace Lessons
{
    internal class ATM
    {
        private long currentBalance;


        public int AmountOf20InBank { get; set; }

        public int AmountOf50InBank { get; set; }

        public int AmountOf100InBank { get; set; }


        public ATM(int amountOf20, int amountOf50, int amountOf100)
        {
            AmountOf20InBank = amountOf20;
            AmountOf50InBank = amountOf50;
            AmountOf100InBank = amountOf100;

            CalculateBalance();
        }


        public void AddMoney(int amountOf20, int amountOf50, int amountOf100)
        {
            AmountOf20InBank += amountOf20;
            AmountOf50InBank += amountOf50;
            AmountOf100InBank += amountOf100;

            CalculateBalance();
        }

        public bool WithdrawMoney(long sum, out int amountOf100ToIssue, out int amountOf50ToIssue, out int amountOf20ToIssue)
        {
            amountOf100ToIssue = 0;
            amountOf50ToIssue = 0;
            amountOf20ToIssue = 0;

            var amountOf100InBank = AmountOf100InBank;
            var amountOf50InBank = AmountOf50InBank;
            var amountOf20InBank = AmountOf20InBank;

            if (sum > currentBalance)
            {
                Console.WriteLine($"\nThe ATM has no enough money :|");
                return false;
            }

            if (sum % 10 != 0)
            {
                Console.WriteLine($"\nYou can`t withdrow current sum.");
                return false;
            }

            if (sum % 20 != 0)
            {
                if (sum < 50 || amountOf50InBank < 1)
                {
                    Console.WriteLine($"\nYou can`t withdrow current sum, not enough banknotes.");
                    return false;
                }
                else
                {
                    sum -= 50;
                    amountOf50ToIssue++;
                    amountOf50InBank -= amountOf50ToIssue;
                }
            }

            if (sum >= 100 && amountOf100InBank > 0)
            {
                var amountOf100InSum = (int)(sum / 100);
                if (amountOf100InBank < amountOf100InSum)
                {
                    sum -= amountOf100InBank * 100;
                    amountOf100ToIssue = amountOf100InBank;
                }
                else
                {
                    sum -= amountOf100InSum * 100;
                    amountOf100ToIssue = amountOf100InSum;
                }

                amountOf100InBank -= amountOf100ToIssue;
            }

            if (amountOf20InBank > 0)
            {
                var amountOf20InSum = (int)(sum / 20);
                if (amountOf20InBank < amountOf20InSum)
                {
                    sum -= amountOf20InBank * 20;
                    amountOf20ToIssue = amountOf20InBank;
                }
                else
                {
                    sum -= amountOf20InSum * 20;
                    amountOf20ToIssue = amountOf20InSum;
                }

                amountOf20InBank -= amountOf20ToIssue;
            }

            if (amountOf50InBank > 0 && sum > 50)
            {
                var amountOf50InSum = (int)(sum / 50);
                if (amountOf50InBank < amountOf50InSum)
                {
                    sum -= amountOf50InBank * 50;
                    amountOf50ToIssue = amountOf50InBank;
                }
                else
                {
                    sum -= amountOf50InSum * 50;
                    amountOf50ToIssue = amountOf50InSum;
                }

                amountOf50InBank -= amountOf50ToIssue;
            }

            if (sum == 0)
            {
                Console.WriteLine("\nCash has been withdrawn successfully.");

                AmountOf100InBank = amountOf100InBank;
                AmountOf50InBank = amountOf50InBank;
                AmountOf20InBank = amountOf20InBank;

                CalculateBalance();
                return true;
            }
            else
            {
                Console.WriteLine($"\nYou can`t withdrow current sum, not enough banknotes.");
                return false;
            }
        }


        private void CalculateBalance()
        {
            currentBalance = (AmountOf20InBank * 20) + (AmountOf50InBank * 50) + (AmountOf100InBank * 100);
        }
    }
}