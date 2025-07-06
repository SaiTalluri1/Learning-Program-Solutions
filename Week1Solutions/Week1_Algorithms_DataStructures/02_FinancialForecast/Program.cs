using System;

namespace FinancialForecast
{
    class Program
    {
        // Recursive method to calculate future value
        static double PredictFutureValue(double currentValue, double rate, int years)
        {
            if (years == 0)
                return currentValue;

            return PredictFutureValue(currentValue * (1 + rate), rate, years - 1);
        }

        static void Main()
        {
            double presentValue = 10000; // ₹10,000
            double growthRate = 0.08;    // 8% annual growth
            int period = 5;              // 5 years

            double futureValue = PredictFutureValue(presentValue, growthRate, period);
            Console.WriteLine($"Estimated value after {period} years: ₹{Math.Round(futureValue, 2)}");
        }
    }
}
