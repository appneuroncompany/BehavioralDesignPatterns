using CommandDesignPattern.CommandPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.CommandPattern.Concrete
{
    public class CalculatorTwo
    {
        public long CalculateProccess(ICalculator calculator, long numberOne, long numberTwo)
        {
           return calculator.Calculate(numberOne, numberTwo);
        }
    }
}
