using exercicioEnum.Entities.enums;
using System;
using System.Globalization;
using exercicioEnum.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY)): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double ValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration(hours)");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, ValuePerHour, hours);
                worker.addContract(contract); // adiciona um contrato de um trabalhador
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY)");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.Write($"Name: {worker.Name}");
            Console.Write($"Department: {worker.Department.Name}");
            Console.Write($"Income for {monthAndYear}: {worker.Income(year,month)}");
        }
    }
}
