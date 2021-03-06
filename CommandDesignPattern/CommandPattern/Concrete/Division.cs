using CommandDesignPattern.CommandPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.CommandPattern.Concrete
{
    public class Division : ICalculator
    {
        public long Calculate(long numberOne, long numberTwo)
        {
            //I know, I have to use try catch exception. But this is not our topic. :)
            return numberOne / numberTwo;
        }
    }
}
