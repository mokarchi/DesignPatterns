using System;
using System.Collections.Generic;
using Strategy.Cook;
using Strategy.Salary;
using Strategy.Sorting;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //var context = new SortedList();
            //context.SetSortStrategy(new QuickSort());
            //context.Sort();

            //CookingMethod cookMethod = new CookingMethod();

            //Console.WriteLine("What food would you like to cook?");
            //var food = Console.ReadLine();
            //cookMethod.SetFood(food);

            //Console.WriteLine("What cooking strategy would you like to use (1-3)?");
            //int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            //switch (input)
            //{
            //    case 1:
            //        cookMethod.SetCookStrategy(new Grilling());
            //        cookMethod.Cook();
            //        break;

            //    case 2:
            //        cookMethod.SetCookStrategy(new OvenBaking());
            //        cookMethod.Cook();
            //        break;

            //    case 3:
            //        cookMethod.SetCookStrategy(new DeepFrying());
            //        cookMethod.Cook();
            //        break;

            //    default:
            //        Console.WriteLine("Invalid Selection!");
            //        break;
            //}

            var reports = new List<DeveloperReport>
        {
            new DeveloperReport {Id = 1, Name = "Dev1", Level = DeveloperLevel.Senior, HourlyRate = 30.5, WorkingHours = 160 },
            new DeveloperReport { Id = 2, Name = "Dev2", Level = DeveloperLevel.Junior, HourlyRate = 20, WorkingHours = 120 },
            new DeveloperReport { Id = 3, Name = "Dev3", Level = DeveloperLevel.Senior, HourlyRate = 32.5, WorkingHours = 130 },
            new DeveloperReport { Id = 4, Name = "Dev4", Level = DeveloperLevel.Junior, HourlyRate = 24.5, WorkingHours = 140 }
        };
            var calculatorContext = new SalaryCalculator(new JuniorDevSalaryCalculator());
            var juniorTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for junior salaries is: {juniorTotal}");
            calculatorContext.SetCalculator(new SeniorDevSalaryCalculator());
            var seniorTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for senior salaries is: {seniorTotal}");
            Console.WriteLine($"Total cost for all the salaries is: {juniorTotal + seniorTotal}");
        }
    }
}
