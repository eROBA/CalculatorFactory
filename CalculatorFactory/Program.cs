using System;

namespace CalculatorFactory
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first number");
            string input = Console.ReadLine();
            double num1, num2;
            bool result = Double.TryParse(input, out num1);
            if (!result)
            {
                Console.WriteLine("Please Enter a Number");
                return;
            }
            Console.WriteLine("Enter second number");
            input = Console.ReadLine();
            result = Double.TryParse(input, out num2);
            if (!result)
            {
                Console.WriteLine("Please Enter a Number");
                return;
            }
            Console.WriteLine("Enter Add, Sub, Mul or Div");
            CalculateFactory factory = new CalculateFactory();
            ICalculate obj = factory.GetCalculation(Console.ReadLine());
            if (obj != null)
            {
                obj.Calculate(num1, num2);
            }
        }
    }
}
