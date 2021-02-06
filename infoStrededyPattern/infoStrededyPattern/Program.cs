using infoStrededyPattern.Strategy;
using System;


namespace infoStrededyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the BMI caculator! Start by disclosing your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Whats your height? (m) (Type it out like 1.xx)");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Whats your Weight? (kg)");
            int weight = Convert.ToInt32(Console.ReadLine());
     


        }
    }
}
