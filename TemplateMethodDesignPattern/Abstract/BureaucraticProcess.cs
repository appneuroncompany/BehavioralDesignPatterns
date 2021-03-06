using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDesignPattern.Abstract
{
    public abstract class BureaucraticProcess
    {
        public abstract void OrderStart();

        void OrderProccess()
        {
            Console.WriteLine("İşlem genel müdürlüğe gönderildi ve Sürüyor");
        }

        void OrderFinish()
        {
            Console.WriteLine("İşlem bitti ve genel müdürlükten yazı geldi");
        }

        public void ExecuteAllProccess()
        {
            OrderStart();
            OrderProccess();
            OrderFinish();

        }
    }
}
