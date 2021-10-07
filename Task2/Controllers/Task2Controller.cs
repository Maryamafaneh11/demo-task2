using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2.Models;
namespace Task2.Controllers
{
    public class Task2Controller : Controller
    {
        public IActionResult Index()
        
        {
            return View("Tndex");
        }
        public IActionResult Index1()
        {
            if (Request.Form["selector"] == "1")
            {
                Teacher tech = new Teacher();

                tech._Fname = Request.Form["textFname"];
                tech._Lname = Request.Form["textLname"];
                tech._salary = Convert.ToDouble(Request.Form["textsalary"]);
                tech._decturction = Convert.ToDouble(Request.Form["textdeduction"]);
                tech._insentive = Convert.ToDouble(Request.Form["textinsentive"]);
                tech._gender = Request.Form["gender"];

                bool isvalid = tech.check();
                if (isvalid == true)
                {



                    double ss = tech.salyy();
                    double zz = tech.Tax(ss);
                    if (zz > 260)
                    {
                        double social = tech.socialsecurity(zz);

                        double NetSalary = zz - social;

                        string msg = tech.print(NetSalary, social);

                        ViewData["mesg"] = msg;
                    }
                    else
                    {
                        string msg = tech.print(zz);

                        ViewData["mesg"] = msg;

                    }
                }
                else
                {
                    string msg = tech.print();

                    ViewData["mesg"] = msg;
                }

            }
            else if (Request.Form["selector"] == "2")
            {
                engineer eng = new engineer();

                eng._Fname = Request.Form["textFname"];
                eng._Lname = Request.Form["textLname"];
                eng._salary = Convert.ToDouble(Request.Form["textsalary"]);
                eng._decturction = Convert.ToDouble(Request.Form["textdeduction"]);
                eng._insentive = Convert.ToDouble(Request.Form["textinsentive"]);
                eng._gender = Request.Form["gender"];

                bool isvalid1 = eng.check();
                if (isvalid1 == true)
                {



                    double ss = eng.salyy();
                    double zz = eng.Tax(ss);
                    if (zz > 260)
                    {
                        double social = eng.socialsecurity(zz);

                        double NetSalary = zz - social;

                        string msg = eng.print(NetSalary, social);

                        ViewData["mesg"] = msg;
                    }
                    else
                    {
                        string msg = eng.print(zz);

                        ViewData["mesg"] = msg;

                    }
                }
                else
                {
                    string msg = eng.print();

                    ViewData["mesg"] = msg;
                }
            }

            else if (Request.Form["selector"] == "3")
            {
                Doctor dr = new Doctor();

                dr._Fname = Request.Form["textFname"];
                dr._Lname = Request.Form["textLname"];
                dr._salary = Convert.ToDouble(Request.Form["textsalary"]);
                dr._decturction = Convert.ToDouble(Request.Form["textdeduction"]);
                dr._insentive = Convert.ToDouble(Request.Form["textinsentive"]);
                dr._gender = Request.Form["gender"];

                bool isvalid1 = dr.check();
                if (isvalid1 == true)
                {



                    double ss = dr.salyy();
                    double zz = dr.Tax(ss);
                    if (zz > 260)
                    {
                        double social = dr.socialsecurity(zz);

                        double NetSalary = zz - social;

                        string msg = dr.print(NetSalary, social);

                        ViewData["mesg"] = msg;
                    }
                    else
                    {
                        string msg = dr.print(zz);

                        ViewData["mesg"] = msg;

                    }
                }
                else
                {
                    string msg = dr.print();

                    ViewData["mesg"] = msg;
                }
            }
            return View("Index");
        }
    }
}
