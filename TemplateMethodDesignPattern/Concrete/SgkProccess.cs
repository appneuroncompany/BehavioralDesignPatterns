using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethodDesignPattern.Abstract;

namespace TemplateMethodDesignPattern.Concrete
{
    public class SgkProccess : BureaucraticProcess
    {
        public override void OrderStart()
        {
            Console.WriteLine("Sgk işlemleri başlattı");
        }
    }
}
