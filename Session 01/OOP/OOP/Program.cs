using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Inheritance;

namespace OOP
{
    internal class Program
    {
        static void Main()
        {
            // WeekDaysPrinter printer = new WeekDaysPrinter();
            // printer.printWeekDays();
            // SessonPrinter sessonPrinter = new SessonPrinter();
            // sessonPrinter.Print();
            // ColorPrinter colorPrinter = new ColorPrinter();
            // colorPrinter.PrintColors();
            // Console.WriteLine("Enter a x1:");
            // int.TryParse(Console.ReadLine(), out int x1);
            // Console.WriteLine("Enter a y1:");
            // int.TryParse(Console.ReadLine(), out int y1);
            // Console.WriteLine("Enter a x2:");
            // int.TryParse(Console.ReadLine(), out int x2);
            // Console.WriteLine("Enter a y2:");
            // int.TryParse(Console.ReadLine(), out int y2);
            //
            // point distans = new point(x1, y1, x2, y2);
            // #region task 01
            // Person[] person1 = new Person[3];
            // person1[0] = new Person("Alice", 30);
            // person1[1] = new Person("Bob", 25);
            // person1[2] = new Person("Charlie", 35);
            //
            // for (int i = 0; i < person1.Length; i++)
            // {
            //     Console.WriteLine($"Name {person1[i].Name} , Age {person1[i].Age}");
            // }
            // #endregion
            //
            // #region task 02
            //
            // Person[] people = new Person[3];
            //
            // for (int i = 0; i < people.Length; i++)
            // {
            //     Console.WriteLine($"Enter the name of person {i + 1}:");
            //     string? name = Console.ReadLine();
            //     Console.WriteLine($"Enter the age of person {i + 1}:");
            //     int.TryParse(Console.ReadLine(), out int age);
            //     people[i] = new Person(name, age);
            //
            // }
            //
            // for (int i = 0; i < people.Length; i++)
            // {
            //     Console.WriteLine($"Name: {people[i].Name}, Age: {people[i].Age}");
            // }
            //
            // #endregion

            //  Parent parent = new Parent(5, 10);
            //  Console.WriteLine(parent.ToString()) ;
            //  Console.WriteLine(parent.prouduct());
            //
            // Child child = new Child(2, 3, 4);
            // Console.WriteLine(child.ToString());
            // Console.WriteLine(child.prouduct());

            Employee[] employee = new Employee[2];

            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine($"Enter the name of employee {i + 1}:");
                string? name = Console.ReadLine();
                Console.WriteLine($"Enter the salary of employee {i + 1}:");
                double.TryParse(Console.ReadLine(), out double salary);
                Console.WriteLine($"Enter the ID of employee {i + 1}:");
                int.TryParse(Console.ReadLine(), out int id);
                Console.WriteLine($"Enter the level of employee {i + 1}:");
                level level = (level)Enum.Parse(typeof(level), Console.ReadLine() ?? "Junior");
                Console.WriteLine($"enter the hire date of employee {i + 1} (yyyy-MM-dd):");
                DateTime.TryParse(Console.ReadLine(), out DateTime hireDate);
                Console.WriteLine($"enter the gender of employee {i + 1}:");
                Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine() ?? "Unknown");
                employee[i] = new Employee();


            }
            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine(employee[i].ToString());
            }
        }
    }
}
