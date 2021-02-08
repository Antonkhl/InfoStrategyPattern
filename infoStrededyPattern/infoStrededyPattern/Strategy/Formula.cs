using System;
using System.Collections.Generic;
using System.Text;

namespace infoStrededyPattern.Strategy
{
    class Formula : BMICaculationStrategy
    {
        public void Calculation(int height, int weight)
        {
            double BMI = weight / height;

            Console.WriteLine("Your BMI is " + BMI);
        }
    }
}
