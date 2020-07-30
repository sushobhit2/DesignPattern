using System;
using System.Collections.Generic;
using System.Text;

namespace AccountState
{
    public class Suspended : State
    {
        public Account _account;
        public Suspended(Account account)
        {
            _account = account;
        }
        public override void Deposit(int amount)
        {
            _account.balance += amount;
            if (_account.balance > 500)
            {
                _account._state = new Active(_account);
            }
            else if (_account.balance < 500)
            {
                _account._state = new OD(_account);
            }
        }

    

        public override void Withdraw(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
