using System;
using System.Collections.Generic;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoSalaryCalculatorStrategyPattern();

            DemoCookingStrategyPattern();
        }

        static void DemoSalaryCalculatorStrategyPattern(){
            var reports = new List<DeveloperReport>
            {
                new DeveloperReport {Id = 1, Name = "Dev1", Level = DeveloperLevelEnum.Senior, HourlyRate = 30.5, WorkingHours = 160 },
                new DeveloperReport { Id = 2, Name = "Dev2", Level = DeveloperLevelEnum.Junior, HourlyRate = 20, WorkingHours = 120 },
                new DeveloperReport { Id = 3, Name = "Dev3", Level = DeveloperLevelEnum.Senior, HourlyRate = 32.5, WorkingHours = 130 },
                new DeveloperReport { Id = 4, Name = "Dev4", Level = DeveloperLevelEnum.Junior, HourlyRate = 24.5, WorkingHours = 140 }
            };

            // instantiate our calculator using a the JuniorDev strategy, calculate the junior dev salary total and print it:
            var calculatorContext = new SalaryCalculator(new JuniorDevSalaryCalculator());
            var juniorTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for junior salaries is: {juniorTotal}");
    
            //  Switch the calculator strategy to Senior, calculate the total and print it:
            calculatorContext.SetCalculator(new SeniorDevSalaryCalculator());
            var seniorTotal = calculatorContext.Calculate(reports);
            Console.WriteLine($"Total amount for senior salaries is: {seniorTotal}");
    
            //  print the overall total:
            Console.WriteLine($"Total cost for all the salaries is: {juniorTotal+seniorTotal}");
        }
        static void DemoCookingStrategyPattern(){
            CookingMethod cookMethod = new CookingMethod();

            Console.WriteLine("What food would you like to cook?");
            var food = Console.ReadLine();
            cookMethod.SetFood(food);

            Console.WriteLine("What cooking strategy would you like to use (1-3)?");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch(input)
            {
                case 1:
                    cookMethod.SetCookStrategy(new Grilling());
                    cookMethod.Cook();
                    break;

                case 2:
                    cookMethod.SetCookStrategy(new OvenBaking());
                    cookMethod.Cook();
                    break;

                case 3:
                    cookMethod.SetCookStrategy(new DeepFrying());
                    cookMethod.Cook();
                    break;

                default:
                    Console.WriteLine("Invalid Selection!");
                    break;
            }
            Console.ReadKey();
                
        }
    }
}
