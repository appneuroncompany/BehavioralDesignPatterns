using ChainOfResponsibilityDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern.Concrete
{
    public class TellerClerk : IExchangeOfficer
    {


        IExchangeOfficer upperUnit;
        public TellerClerk(IExchangeOfficer upperUnit)
        {
            this.upperUnit = upperUnit;
        }

        public string Name { get; set; }

        public void ExchangeProccess(ExchangeOrder order)
        {
            Name = "Teller Clerk";


            if (order.orderCount <= 50000)
            {
                Console.WriteLine("Merhaba ben " + this.Name + " işlem gerçekleşti. Değişen para: " + order.orderCount);
            }
            else
            {
                Console.WriteLine("Merhaba ben " + this.Name + ". İşlem için yüksek miktar. Üst birimim olan " + upperUnit.Name + "'e yönlendiriliyor...");
                ForwardToUpperUnit(order);
            }
        }

        void ForwardToUpperUnit(ExchangeOrder order)
        {
            upperUnit.ExchangeProccess(order);
        }
    }
}
