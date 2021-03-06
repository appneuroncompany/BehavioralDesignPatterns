using ChainOfResponsibilityDesignPattern.Concrete;
using System;

namespace ChainOfResponsibilityDesignPattern
{
    /// <summary>
    /// İstemcinin isteği var ve bu isteğin hedefe ulaşıncaya kadar üzerinde bir takım işlemler yapılması gerekiyor ,
    /// bir takım processing sınıflar tarafından bu isteğin işlenmesi ve bir sonraki işlemciye geçirilmesi gerektiği durumlarda kullanılmalıdır.
    /// </summary>
    public class ChainOfResponsibilityDesign
    {
        public static void TestChainResponsibilityDesign()
        {
            GeneralManager generalManager = new GeneralManager();
            generalManager.Name = "Genel yönetici Burak";

            CashierManager cashierManager = new CashierManager(generalManager);
            cashierManager.Name = "Vezne müdürü Mehmet";

            TellerClerk tellerClerk = new TellerClerk(cashierManager);
            tellerClerk.Name = "Vezne görevlisi İhsan";

            ExchangeOrder exchangeOrder1 = new ExchangeOrder(145000);
            ExchangeOrder exchangeOrder2 = new ExchangeOrder(750000);

            tellerClerk.ExchangeProccess(exchangeOrder1);
            Console.WriteLine("///////////////////////////////////////////////////");
            tellerClerk.ExchangeProccess(exchangeOrder2);

        }
    }
}
