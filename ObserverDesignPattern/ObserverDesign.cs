using ObserverDesignPattern.Concrete;
using System;

namespace ObserverDesignPattern
{
    /// <summary>
    /// tüm UI bileşenlerinin haberleşme ve iletişim temelini oluşturur. 
    /// Bileşenlerin üzerinedeki Mouse, Keyboard, Gesture eventlerini dinleyip nesnede oluşan değişikliklerini kendilerini dinleyen Observer sınıflarına iletirler.
    /// </summary>
    public class ObserverDesign
    {
        
       
        public static void TestObserverDesgn()
        {
            RobotSoldier robotSoldier1 = new RobotSoldier();
            RobotSoldier robotSoldier2 = new RobotSoldier();
            RobotSoldier robotSoldier3 = new RobotSoldier();

            HumanSoldier humanSoldier1 = new HumanSoldier();
            HumanSoldier humanSoldier2 = new HumanSoldier();
            HumanSoldier humanSoldier3 = new HumanSoldier();

            General general = new General();

            general.AddSoldier(robotSoldier1);
            general.AddSoldier(robotSoldier2);
            general.AddSoldier(robotSoldier3);

            general.AddSoldier(humanSoldier1);
            general.AddSoldier(humanSoldier2);
            general.AddSoldier(humanSoldier3);

            general.Order = "Hucumm";
            Console.WriteLine("//////////////////////////////////////////");
            general.Order = "Duruunn";


        }

    }
}
