namespace BankAccount
{
    /*
    public Dictionary<string, int> Spells
        {
            get
            {
                return spells;
            }
        }
    */
    class Account
    {
        public string name;
        public string Name
        {
            get { return name; }
        }

        public int balance;
        public int Balance
        {
            get { return Balance; }
        }

        public Account(string Name, int Balance)
        {
            name = Name;
            balance = Balance;
        }

        // CheckBalance() => string
        public string CheckBalance()
        {
            return String.Format("{0} has {1} in this account", name, balance);
        }

        // Deposit() => string
        public string Deposit(int amount)
        {
            balance += amount;
            return String.Format("{0} was deposited to this account", amount);
        }

        // Withdraw() => string
        public string Withdraw(int amount)
        {
            int currentBalance = balance - amount;

            if (currentBalance < 0)
            {
                return "Not enough funds";
            }
            else
            {
                balance -= amount;
                return String.Format("{0} was withdrawn from this account");
            }
        }
    }
}
