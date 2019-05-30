using System;

namespace CalculatorFactory
{
    public class Add : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine("a + b = {0}", a + b);
        }

    }
}
