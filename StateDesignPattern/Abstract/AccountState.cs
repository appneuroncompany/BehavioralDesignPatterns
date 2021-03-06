using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern.Abstract
{
    public interface AccountState
    {
        void GetMoney();

        void PayInterest();
    }
}
