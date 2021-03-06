using StateDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern.concrete
{
    public class ClassicAccount : AccountState
    {
        public void PayInterest()
        {
            Console.WriteLine("Klasik hesaba göre faiz ödeniyor...");
        }

        public void GetMoney()
        {
            Console.WriteLine("Klasik hesaba göre para çekiliyor...");
        }
    }
}
