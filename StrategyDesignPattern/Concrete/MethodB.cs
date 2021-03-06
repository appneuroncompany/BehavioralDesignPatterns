using StrategyDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.Concrete
{
    public class MethodB : IDeptCalculating
    {
        public void DeptCalculator()
        {
            Console.WriteLine("Yöntem B ya göre hesaplama yapıldı...");
        }
    }
}
