using System;

namespace AccountState
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            account.Withdraw(400);
            Console.WriteLine(account._state);
            account.Withdraw(400);
            Console.WriteLine(account._state);
            account.Deposit(500);
            Console.WriteLine(account._state);
            account.Deposit(400);
            Console.WriteLine(account._state);
        }
    }
}
