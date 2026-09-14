using System;

namespace CalculatorApplication
{
    public delegate T Information<T>(T arg1, T arg2);

    internal class CalculatorClass
    {
        public Information<double> value1;
        public Information<double> value2;

        public double GetSum(double value1, double value2)
        {
            return value1 + value2;
        }

        public double GetDifference(double value1, double value2)
        {
            return value1 - value2;
        }

        public double GetProduct(double value1, double value2)
        {
            return value1 * value2;
        }

        public double GetQuotient(double value1, double value2)
        {
            return value1 / value2;
        }

        private Information<double> calculatorHandler;


        public event Information<double> CalculateEvent
        {
            add
            {
                calculatorHandler += value;
                Console.WriteLine("Added the write line");
            }

            remove
            {
                calculatorHandler -= value;
                Console.WriteLine("Removed the write line");
            }
        }

        public double Calculate(double value1, double value2)
        {
            return calculatorHandler?.Invoke(value1, value2) ?? 0.0;
        }
    }
}