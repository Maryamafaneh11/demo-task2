using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2.Models
{
    public class Doctor:Employee
    {
        public override double Tax(double x)
        {
            double allTax = 0;
            if (salary <= 500 && 260 <= salary)
            {
                allTax = salary - 0.05;
            }
            else if (salary <= 750 && 500 <= salary)
            {
                allTax = salary - 7.05;
            }

            else if (salary >= 750)
            {
                allTax = salary - 0.10;
            }
            return allTax;
        }

        public override double socialsecurity(double ss)
        {
            double socialsecury = 0;
            if (_gender == "Female")
            {
                if (ss < 500)
                {
                    socialsecury = 35;
                }
                else
                {
                    socialsecury = 50;
                }
            }
            else
            {

                if (ss < 500)
                {
                    socialsecury = 30;
                }
                else
                {
                    socialsecury = 45;
                }
            }
            return socialsecury;
        }


    }
}
