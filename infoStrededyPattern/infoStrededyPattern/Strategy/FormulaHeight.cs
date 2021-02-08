using System;
using System.Collections.Generic;
using System.Text;

namespace infoStrededyPattern.Strategy
{
   namespace infoStrededyPattern
    {
       class FormulaHeight : BMICaculationStrategy
        {
            public void Calculation(double height)
            {
                height = Math.Pow(height, 2);

                bmi = new Formula();
            
            }
        }
    }
}
