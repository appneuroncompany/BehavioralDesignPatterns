using StateDesignPattern.concrete;
using System;

namespace StateDesignPattern
{
    /// <summary>
    /// State örüntüsü, nesnenizin iç durumunu(state)’unda yapması gereken davranışları birbirinden soyutlamak için oluşturulmuştur.
    /// Oyun geliştirmede çok kullanılan bir örüntüdür. Oyundaki nesnelerin hareketlerini belli durumlara göre gerçekleştirmeniz gerekir. 
    /// Nesnenin ilgili durumda yapacağı hareketleri ve davranışları bu State sınıfları belirler.
    /// </summary>
    public class StateDesign
    {

        public static void TestStateDesign()
        {
            AccountManager accountManager = new AccountManager();
            accountManager.PayInterest();

            Console.WriteLine("//////////////////////////////////");

            accountManager.ChangeState(new GoldAccount());
            accountManager.GetMoney();
        }
        
    }
}
