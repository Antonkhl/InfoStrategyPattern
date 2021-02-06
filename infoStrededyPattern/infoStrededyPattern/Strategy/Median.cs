using System;
using System.Collections.Generic;
using System.Text;

namespace infoStrededyPattern.Strategy
{
    class Median
    {
        public void medianCaculation(double bmi, int age)
        {
            if (age <= 19) {
                kidMedian();
            }

            if (age >= 20 && age <= 29)
            {
                youngAdultMedian(bmi);
            }

            if (age >= 30 && age <= 49)
            {
                olderAdultMedian(bmi);
            }

            if (age >= 50 && age <= 64)
            {
                almostThere(bmi);
            }

            if (age >= 65)
            {
                pensioner(bmi);
            }
        }

        public void kidMedian()
        {
            string median = "Your age group has no clear median!";
        }

        public void youngAdultMedian(double bmi)
        {
            if (bmi <=  18.5)
            {
                string median = "You and 3.1% of your age group is Underweight!";
            }

            if (bmi >= 18.6 && bmi <= 24.9)
            {
                string median = "You and 62.3% of your age group is Normal weight!";
            }

            if (bmi >= 25 && bmi <= 29.9)
            {
                string median = "You and 23.5% of your age group is Overweight!";
            }

            if (bmi >= 30)
            {
                string median = "You and 10.2% of your age group is Overweight!";
            }

        }

        public void olderAdultMedian(double bmi)
        {
            if (bmi <= 18.5)
            {
                string median = "You and 1.4% of your age group is Underweight!";
            }

            if (bmi >= 18.6 && bmi <= 24.9)
            {
                string median = "You and 48.5% of your age group is Normal weight!";
            }

            if (bmi >= 25 && bmi <= 29.9)
            {
                string median = "You and 37% of your age group is Overweight!";
            }

            if (bmi >= 30)
            {
                string median = "You and 13.1% of your age group is Overweight!";
            }
        }

        public void almostThere(double bmi)
        {
            if (bmi <= 18.5)
            {
                string median = "You and 0.5% of your age group is Underweight!";
            }

            if (bmi >= 18.6 && bmi <= 24.9)
            {
                string median = "You and 39.4% of your age group is Normal weight!";
            }

            if (bmi >= 25 && bmi <= 29.9)
            {
                string median = "You and 40.2% of your age group is Overweight!";
            }

            if (bmi >= 30)
            {
                string median = "You and 19.9% of your age group is Overweight!";
            }
        }

        public void pensioner(double bmi)
        {
            if (bmi <= 18.5)
            {
                string median = "You and 1.7% of your age group is Underweight!";
            }

            if (bmi >= 18.6 && bmi <= 24.9)
            {
                string median = "You and 42.2% of your age group is Normal weight!";
            }

            if (bmi >= 25 && bmi <= 29.9)
            {
                string median = "You and 41.6% of your age group is Overweight!";
            }

            if (bmi >= 30)
            {
                string median = "You and 14.5% of your age group is Overweight!";
            }
        }



    }
}
