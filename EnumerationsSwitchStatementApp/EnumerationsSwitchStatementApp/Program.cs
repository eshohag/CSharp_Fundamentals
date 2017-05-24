using System;
using System.Collections.Generic;

namespace EnumerationsSwitchStatementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> allTasks = new List<Task>()
            {
                new Task(){Description = "Task-001",EstimatedHours = 6,Status =Status.Completed },
                new Task(){Description = "Task-002",EstimatedHours = 2,Status =Status.InProgress },
                new Task(){Description = "Task-003",EstimatedHours = 8,Status =Status.NotYetStarted },
                new Task(){Description = "Task-004",EstimatedHours = 12,Status =Status.Deleted },
                new Task(){Description = "Task-005",EstimatedHours = 6,Status =Status.OnHold },
                new Task(){Description = "Task-006",EstimatedHours =2,Status =Status.InProgress },
                new Task(){Description = "Task-007",EstimatedHours = 14,Status =Status.NotYetStarted },
                new Task(){Description = "Task-008",EstimatedHours = 8,Status =Status.Completed },
            };
            GetPrintAssesment(allTasks);
            Console.ReadKey();
        }

        private static void GetPrintAssesment(List<Task> allTasks)
        {
            foreach (Task aTask in allTasks)
            {
                switch (aTask.Status)
                {
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        break;
                    case Status.NotYetStarted:
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Red;

                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.WriteLine("Not Found!");
                        break;
                }
                Console.WriteLine(aTask.Description + "----Task is " + aTask.Status);
            }
        }
    }
}
