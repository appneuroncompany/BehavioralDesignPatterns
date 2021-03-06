using StateDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern.concrete
{
    public class GoldAccount : AccountState
    {
        public void PayInterest()
        {
            Console.WriteLine("Altın hesabına göre faiz ödeniyor...");
        }

        public void GetMoney()
        {
            Console.WriteLine("Altın hesabına göre para çekiliyor...");
        }
    }
}
