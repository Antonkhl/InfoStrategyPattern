using System;
using System.Collections.Generic;
using System.Text;

namespace infoStrededyPattern.Strategy
{
   namespace infoStrededyPattern
    {
       class FormulaHeight
        {
            public void HeightCaculations(double height)
            {
                height = Convert.ToInt32(height) ^ Convert.ToInt32(height);
              
            }
        }
    }
}
