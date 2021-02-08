using System;
using System.Collections.Generic;
using System.Text;

namespace infoStrededyPattern.Strategy
{
    class BMICaculationStrategy
    {
        interface BMIcaculationStrategy
        {
            void Calculate(double height, int weight); 
        }
    }
}
