using CommandDesignPattern.CommandPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.CommandPattern.Concrete
{
    public  class Multiplication : ICalculator
    {
        public long Calculate(long numberOne, long numberTwo)
        {
            return numberOne * numberTwo;
        }
    }
}
