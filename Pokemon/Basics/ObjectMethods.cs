using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Basics
{
    internal class Student
    {
        public string name;
        public string subject;
        public double gpa;

        // Stating a Public Constructor 
        public Student(string sname, string ssubject, double sgpa) {
            name = sname;
            subject = ssubject;
            gpa = sgpa;
        }


        // Defining an object method 
        public bool hasMerit() {
            if (gpa >= 5) return true;
            else
                return false;
        }
    }
}
