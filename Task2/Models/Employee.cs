using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2.Models
{
    public abstract class Employee
    {
       protected string Fname;
        protected string Lname;
        protected double salary;
        protected string gender;

        double decturction;
        double insentive;



        public double _decturction
        {
            set { decturction = value; }
            get { return decturction; }
        }

        public double _insentive
        {
            set { insentive = value; }
            get { return insentive; }
        }





        public string _Fname
        {
            set { Fname = value; }
            get { return Fname; }
        }

        public string _Lname
        {
            set { Lname = value; }
            get { return Lname; }
        }

        public double _salary
        {
            set { salary = value; }
            get { return salary; }
        }

        public string _gender
        {
            set { gender = value; }
            get { return gender; }
        }


        public  bool check()
        {
            if (Fname != "" && Lname != "" && salary > 200 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public  double salyy()
        {
           double net_salary = salary - decturction + insentive;
            return net_salary;
        }

        

        public abstract double Tax(double t);

        public abstract double socialsecurity(double ss);

        public   string print(double salary, double  socialsecurity)
        {
           // string messg = "Hello you completed registeration form successfully Mr." + Fname + Lname + "we will decduct form your salary:" + socialsecurity(ss) + "you salary after decduct:" + socialsecurity( ss);
            return string.Empty;
        }

        public  string print()
        {
            string messg = "Please Enter & fill" + " Enter your First Name" + Fname+"Enter Your Last Name"+Lname+"and Your Salary should more than 200 JD";
            return messg;
        }

        public  string print(double salary)
        {
            string messg = "Sorry! You cannot Join with Us." + "Tax applied on your salary:" + salary;
            return messg;
        }

    }
}
