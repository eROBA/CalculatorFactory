using System;

namespace CalculatorFactory
{
    public class CalculateFactory
    {
        public ICalculate GetCalculation(string type)
        {
            ICalculate obj = null;
            if (type.ToLower().Equals("add"))
            {
                obj = new Add();
            }
            else if (type.ToLower().Equals("sub"))
            {
                obj = new Sub();
            }
            else if (type.ToLower().Equals("mul"))
            {
                obj = new Mul();
            }
            else if (type.ToLower().Equals("div"))
            {
                obj = new Div();
            }
            else
            {
                Console.WriteLine("We don't do that");
            }
            return obj;
        }
    }
}
