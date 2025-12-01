using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithCreditCard.MyClasses
{
    public class CreditCard
    {
        public int accountNumber;
        public decimal balance;

        public CreditCard(int accountNumber, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void AddMoneyToAccount(decimal balance, decimal amountToAdd)
        {
            Console.WriteLine("\nMoney is now being credited to your card...");
            if (amountToAdd >= 0)
            {
                this.balance += amountToAdd;
            }
            else
            {
                Console.WriteLine("Enter amount more than 0!");
                return;
            }
        }

        public void TakeMoneyFromAccount(decimal balance, decimal amountToTake)
        {
            //Console.Write("Enter amount what you want to take: ");
            //decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nMoney is now being debited from your card...");
            if (amountToTake <= balance && amountToTake >= 0)
            {
                this.balance -= amountToTake;
            }
            else
            {
                Console.WriteLine("Not enough money on account or invalid amount!");
                return;
            }
        }

        public void ShowAccountBalance(decimal balance, int accountNumber)
        {
            Console.WriteLine($"Your account {accountNumber} balance is: {balance}$");
        }
    }
}
