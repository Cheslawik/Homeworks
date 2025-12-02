using OperationsWithCreditCard.MyClasses;

namespace OperationsWithCreditCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard1 = new CreditCard(468684522, 5000m);
            CreditCard creditCard2 = new CreditCard(216848468, 3000m);
            CreditCard creditCard3 = new CreditCard(848646448, 1000m);

            Console.WriteLine($"Current balance on account number {creditCard1.accountNumber} is {creditCard1.balance}.");
            Console.WriteLine($"Current balance on account number {creditCard2.accountNumber} is {creditCard2.balance}.");
            Console.WriteLine($"Current balance on account number {creditCard3.accountNumber} is {creditCard3.balance}.");

            creditCard1.AddMoneyToAccount(creditCard1.balance, 600m);
            creditCard1.ShowAccountBalance(balance: creditCard1.balance, creditCard1.accountNumber);
            //Console.WriteLine($"Updated balance on account number {creditCard1.accountNumber} is {creditCard1.balance}.");

            creditCard2.AddMoneyToAccount(creditCard2.balance, 400m);
            creditCard2.ShowAccountBalance(balance: creditCard2.balance, creditCard2.accountNumber);
            //Console.WriteLine($"Updated balance on account number {creditCard2.accountNumber} is {creditCard2.balance}.");

            creditCard3.TakeMoneyFromAccount(creditCard3.balance, 200m);
            creditCard3.ShowAccountBalance(balance: creditCard3.balance, creditCard3.accountNumber);
            //Console.WriteLine($"Updated balance on account number {creditCard3.accountNumber} is {creditCard3.balance}.");


        }
    }
}
