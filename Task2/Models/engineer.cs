using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2.Models;
namespace Task2.Models
{
    public class engineer:Employee
    {
        public override double Tax(double x)
        {
            double allTax = 0;
            if (salary <= 500 && 260 <= salary)
            {
                allTax = salary - 2.02;
            }
            else if (salary <= 750 && 500 <= salary)
            {
                allTax = salary - 0.05;
            }

            else if (salary >= 750)
            {
                allTax = salary - 7.05;
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
                    socialsecury = 32;
                }
                else
                {
                    socialsecury = 51;
                }
            }
            else
            {

                if (ss < 500)
                {
                    socialsecury = 15;
                }
                else
                {
                    socialsecury = 35;
                }
            }
            return socialsecury;
        }



    }
}
