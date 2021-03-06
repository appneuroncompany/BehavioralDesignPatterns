using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.CommandPattern.Abstract
{
    public interface ICalculator
    {
        long Calculate(long numberOne, long numberTwo);
    }
}
