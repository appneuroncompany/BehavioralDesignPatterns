using System;
using TemplateMethodDesignPattern.Concrete;

namespace TemplateMethodDesignPattern
{
    public class TemplateMethod
    {
        public static void TestTemplateMethod()
        {
            SgkProccess sgkProccess = new SgkProccess();
            OtherInsuranceCompany otherInsuranceCompany = new OtherInsuranceCompany();

            sgkProccess.ExecuteAllProccess();
            otherInsuranceCompany.ExecuteAllProccess();

        }
    }
}
