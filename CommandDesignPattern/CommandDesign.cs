using CommandDesignPattern.CommandPattern.Concrete;
using System;

namespace CommandDesignPattern
{
    /// <summary>
    /// Open closed prensibine uygun hale getirmek için kullanılabilir..
    /// </summary>
    public class CommandDesign
    {
        public static void TestCommandDesign()
        {
            CalculatorTwo calculatorTwo = new CalculatorTwo();
            long number1 = calculatorTwo.CalculateProccess(new Division(), 56565656, 550);
            long number2 = calculatorTwo.CalculateProccess(new Addition(), 35, 550);
            long number3 = calculatorTwo.CalculateProccess(new Extraction(), 35, 550);
            long number4 = calculatorTwo.CalculateProccess(new Multiplication(), 35, 550);

            Console.WriteLine(number4 + "\n");
            Console.WriteLine(number3 + "\n");
            Console.WriteLine(number2 + "\n");
            Console.WriteLine(number1 + "\n");
        }
    }
}
