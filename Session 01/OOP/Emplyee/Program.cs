using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Emplyee
{
    internal class Program
    {

        static void Main(string[] args)
        {
           Employee[] employees = new Employee[3];

           Employee.insert(employees);
          
           Employee employeeInstance = new Employee();
           employeeInstance.printinfo(employees);

        }
    }
}