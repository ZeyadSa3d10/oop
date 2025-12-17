using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Employee
    {
        private string Name;
        private double Salary;
        private int ID;
        private string Level;
        Hairingdate hiredate;
        private string Gender;

        public string name { get; set; }
        public double salary { get; set; }
        public int id { get; set; }
        level level { get; set; }

        Gender gender { get; set; }
        internal Hairingdate Hiredate { get; set; }

        public Employee()
        { hiredate = new Hairingdate(); }

        public override string ToString()
        {
            return $"Name: {Name}, Salary: {Salary}, ID: {ID}, Level: {Level}, Hiredate: {hiredate}";
        }
    }
}