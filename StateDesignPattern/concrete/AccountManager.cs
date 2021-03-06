using StateDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern.concrete
{
    public class AccountManager
    {
        AccountState accountState;
        public AccountManager()
        {
            this.accountState = new ClassicAccount();
        }

        public void GetMoney()
        {
            accountState.GetMoney();
        }

        public void PayInterest()
        {
            accountState.PayInterest();
        }

        public void ChangeState(AccountState accountState)
        {
            this.accountState = accountState;
        }
    }
}
