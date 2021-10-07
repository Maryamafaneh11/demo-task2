using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2.Models;

namespace Task2.Models
{
    public class Teacher : Employee
    {

    

        public override double Tax(double x)
        {
            double allTax = 0;
            if (salary <= 500 && 260 <= salary)
            {
                allTax = salary - 0;
            }
            else if (salary <= 750 && 500 <= salary)
            {
                allTax = salary - 0.03;
            }

            else if (salary >= 750)
            {
                allTax = salary - 0.05;
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
                    socialsecury = 20;
                }
                else
                {
                    socialsecury =40;
                }
            }
            else
            {

                if (ss < 500)
                {
                    socialsecury =  10;
                }
                else
                {
                    socialsecury = 20;
                }
            }
            return socialsecury;
        }


    }
}

