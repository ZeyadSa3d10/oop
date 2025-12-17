using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Emplyee
{
    internal class Employee
    {
        int id;
        string name;
        Level level;
        double salary;
        HiringDate hireDate;
        Gender gender;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        internal Level Level1 { get => level; set => level = value; }
        internal HiringDate HireDate { get => hireDate; set => hireDate = value; }
        internal Gender Gender { get => gender; set => gender = value; }

        public Employee()

        {
        }
        public Employee(string name, double salary, int id, Level level, HiringDate hireDate, Gender gender)
        {
            Name = name;
            Salary = salary;
            Id = id;
            Level1 = level;
            HireDate = hireDate;
            this.gender = gender;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Salary: {Salary}, ID: {Id}, Level: {Level1}, HireDate: {HireDate}";
        }

        public static void insert(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee();
            }
            Console.WriteLine(" please entsr the employee data ");
            bool flag;
            for (int i = 0; i < employees.Length; i++) {
                do
                {
                    Console.WriteLine(" enter id employye num 1 ");
                    flag = int.TryParse(Console.ReadLine(), out employees[i].id);
                } while (!flag);
                do
                {
                    Console.WriteLine(" enter name emplyee numn 1");
                    employees[i].name = Console.ReadLine();
                } while (string.IsNullOrEmpty(employees[i].name));

                do
                {
                    Console.WriteLine(" please enter the salary ");
                    flag = double.TryParse(Console.ReadLine(), out employees[i].salary);
                } while (!flag && employees[i].salary <= 0);

                int gendernum;
                Console.WriteLine(" for  Female enrer 1 for Male enter 2 ");
                do
                {
                    Console.WriteLine(" enter gender ");
                    flag = int.TryParse(Console.ReadLine(), out gendernum);
                } while (!flag && !Enum.IsDefined(typeof(Gender), gendernum));
                employees[i].gender = (Gender)gendernum;

                Console.WriteLine(" guest=0 ,, Developer=1 ,,, secretary =2 ,, DBA=3");
                int seclevel;
                do
                {

                    Console.WriteLine(" enter level ");
                    flag = int.TryParse(Console.ReadLine(), out seclevel);

                } while (!flag && seclevel < 0 && seclevel > 15);
                employees[i].level = (Level)seclevel;
                
                Console .WriteLine(" enter hiring date ");
                int day, month, year;
                do
                {
                    Console.WriteLine(" enter day ");
                    flag = int.TryParse(Console.ReadLine(), out day);
                } while (!flag && day < 1 && day > 31);
                do
                {
                    Console.WriteLine(" enter month ");
                    flag = int.TryParse(Console.ReadLine(), out month);
                } while (!flag && month < 1 && month > 12);
                do
                {
                    Console.WriteLine(" enter year ");
                    flag = int.TryParse(Console.ReadLine(), out year);
                } while (!flag && year < 1900 && year > DateTime.Now.Year);
                employees[i].hireDate = new HiringDate(day, month, year);


                


    
            }
        }

        public void printinfo(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                
           Console.WriteLine(employees[i]);
            }
        }

    }
}  

