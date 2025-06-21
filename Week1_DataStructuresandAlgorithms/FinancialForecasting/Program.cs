using System;

namespace FinancialForecasting
{
    public static class Forecast
    {
        // Recursive method to calculate future value
        public static double PredictValue(double initialValue, double growthRate, int years)
        {
            if (years == 0)
                return initialValue;

            return PredictValue(initialValue * (1 + growthRate), growthRate, years - 1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Financial Forecasting Tool ---");
            
            Console.Write("Enter initial value: ");
            double initial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter annual growth rate (e.g., 0.05 for 5%): ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number of years to forecast: ");
            int years = Convert.ToInt32(Console.ReadLine());

            double futureValue = Forecast.PredictValue(initial, rate, years);
            Console.WriteLine($"\nPredicted Value after {years} years: {futureValue:F2}");
        }
    }
}