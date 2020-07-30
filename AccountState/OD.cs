using System;
using System.Collections.Generic;
using System.Text;

namespace AccountState
{
    public class OD : State
    {
      public  Account _account;
        public OD(Account account)
        {
            _account = account;
        }
        public override void Deposit(int amount)
        {
            _account.balance += amount;
            if (_account.balance > 500)
            {
                _account._state = new Active(this._account);
            }
        }
        public override void Withdraw(int amount)
        {
            _account.balance -= amount;
            if (_account.balance < 0)
            {
                _account._state = new Suspended(this._account);
            }
        }
    }
}
