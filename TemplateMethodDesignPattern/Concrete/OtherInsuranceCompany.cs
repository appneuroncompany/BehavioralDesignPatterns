using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethodDesignPattern.Abstract;

namespace TemplateMethodDesignPattern.Concrete
{
    class OtherInsuranceCompany : BureaucraticProcess
    {
        public override void OrderStart()
        {
            Console.WriteLine("OtherInsuranceCompany süreçleri başlattı.");
        }
    }
}
