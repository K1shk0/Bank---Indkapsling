using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Account
    {
        private double balance;
        private AccountOwner _owner;

        public Account(AccountOwner owner ,double startupAmount)
        {
            balance = startupAmount;
            _owner = owner;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Du har indsat {0} kr. Din saldo nu er {1} kr.", amount, balance);
            }

            else
            {
                Console.WriteLine("Beløbet skal være større end 0");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Du har trukket {0} kr. Din saldo nu er {1}", amount, balance);
            }

            else
            {
                Console.WriteLine("Ugyldigt beløb. Beløbet skal være positivt og ikke over din saldo.");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Din saldo er nu på {balance} kr.");
        }
    }
}
