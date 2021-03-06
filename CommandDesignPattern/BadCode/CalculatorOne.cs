using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPattern.BadCode
{
    public enum CalculateSwither
        {
        toplama,
        cıkarma,
        carpma,
        bolme
    }
    class CalculatorOne
    {
        public long Calculate(CalculateSwither calculateSwither, long numberOne, long numberTwo)
        {
            long result =0;

            switch (calculateSwither)
            {
                case CalculateSwither.toplama:
                    result = numberOne + numberTwo;
                    break;
                case CalculateSwither.cıkarma:
                    result = numberOne - numberTwo;
                    break;
                case CalculateSwither.carpma:
                    result = numberOne * numberTwo;
                    break;
                case CalculateSwither.bolme:
                    result = numberOne / numberTwo;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
