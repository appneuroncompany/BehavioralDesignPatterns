using StrategyDesignPattern.Concrete;
using System;

namespace StrategyDesignPattern
{
    /// <summary>
    /// Strategy örüntüsü sizin nesnenizin içindeki davranışı soyutlayıp dışarıdan bu davranışı/stratejiyi nesneye ekleyerek çalıştırmanızı sağlar.
    /// </summary>
    public class StrategyPattern
    {
        public static void TestStrategyPattern()
        {
            LenderInstitution lenderInstitutionA = new LenderInstitution(new MethodA());
            lenderInstitutionA.CalculateDept();
            LenderInstitution lenderInstitutionB = new LenderInstitution(new MethodB());
            lenderInstitutionB.CalculateDept();

        }
    }
}
