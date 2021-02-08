using System;
using System.Collections.Generic;
using System.Text;

namespace infoStrededyPattern.Strategy
{
    class Caculation
    {
        private BMICaculationStrategy _BMI;

        public Caculation(BMICaculationStrategy bmi)
        {
            _BMI = bmi;
        }

        public void CalculationInterface(double height, int weight)
        {
            _BMI.Calculate(height, weight);
        }


    }
}
