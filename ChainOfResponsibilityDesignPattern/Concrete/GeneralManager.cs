using ChainOfResponsibilityDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern.Concrete
{
    public class GeneralManager: IExchangeOfficer
    {
        public string Name { get; set; }

        public void ExchangeProccess(ExchangeOrder order)
        {

            if (order.orderCount <= 500000)
            {
                Console.WriteLine("Merhaba ben " + this.Name + " işlem gerçekleşti. Değişen para: " + order.orderCount);
            }
            else
            {
                Console.WriteLine("Merhaba ben "+ this.Name + " İşlem gerçekleşemez. Günlük limiti aşmaktadır...");
            }
        }

    }
}
