using System;
using System.Collections.Generic;
using System.Text;

namespace AccountState
{
    public abstract class State
    {
        public int ODAmount = 500;
       
        public abstract void Deposit(int amount);
        public abstract void Withdraw(int amount);
    }
}
