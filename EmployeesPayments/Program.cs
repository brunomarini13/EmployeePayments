using System;
using System.Globalization;
using System.Collections.Generic;
using EmployeesPayments.Entities;

namespace EmployeesPayments
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> ListOfEmployees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int numberEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char answer = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (answer == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    OutsourcedEmployee employee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    ListOfEmployees.Add(employee);
                }
                else
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    ListOfEmployees.Add(employee);
                }

            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            for (int i = 0; i < numberEmployees; i++)
            {
                Console.WriteLine(ListOfEmployees[i]);
            }
        }
    }
}
