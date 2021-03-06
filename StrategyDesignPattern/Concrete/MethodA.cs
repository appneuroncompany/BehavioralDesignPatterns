using StrategyDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Concrete
{
    public class MethodA : IDeptCalculating
    {
        public void DeptCalculator()
        {
            Console.WriteLine("Yöntem A ya göre hesaplama yapıldı...");
        }
    }
}
