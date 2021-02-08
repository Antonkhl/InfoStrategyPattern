using infoStrededyPattern.Strategy;
using System;


namespace infoStrededyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BMICaculationStrategy bmi;

            Console.WriteLine("Welcome to the BMI caculator! Start by disclosing your height (meters) (Type it out like 1,xx)");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Whats your Weight? (kg)");
            int weight = Convert.ToInt32(Console.ReadLine());

            bmi = new Strategy.infoStrededyPattern.FormulaHeight();



        }
    }
}
