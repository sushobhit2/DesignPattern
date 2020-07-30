using System;
using System.Collections.Generic;
using System.Text;

namespace AccountState
{
    public class Account
    {
        public State _state;
        public int balance;
        public Account()
        {
            balance = 600;
            _state = new Active(this);
        }
        public void Deposit(int amount)
        {
            _state.Deposit(amount);
        }
        public void Withdraw(int amount)
        {
            _state.Withdraw(amount);
        }
    }
}
