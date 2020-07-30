using System;
using System.Collections.Generic;
using System.Text;

namespace AccountState
{
    public class Active : State
    {
        public Account _account;
        public Active(Account account)
        {
            _account = account;
        }

     
        public override void Deposit(int amount)
        {
            _account.balance += amount;
        }


        public override void Withdraw(int amount)
        {
            _account.balance -= amount;
            if (_account.balance < 0)
            {
                _account._state = new Suspended(_account);
            }
            else if(_account.balance<500){
                _account._state = new OD(_account);
            }
        }
    }
}
