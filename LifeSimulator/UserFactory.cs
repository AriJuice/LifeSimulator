using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LifeSimulator
{
    internal class UserFactory
    {

        public static string CreateName()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("            |--------------|          ");
            Console.WriteLine("            |Life Simulator|          ");
            Console.WriteLine("            |--------------|          ");

            ConsoleSupport.SpareLine(1);
            string name = string.Empty;
            bool invalidName = false;

            while (true)
            {
                ConsoleSupport.SpareLine(2);
                invalidName = false;
                Console.WriteLine("What will your name be?");
                Console.Write("--> ");
                name = Console.ReadLine();

                foreach (var item in name)
                {
                    if (name.Contains(" "))
                    {
                        ConsoleSupport.PrintError("Your name cannot include any spaces");
                        invalidName = true;
                        break;
                    }
                    else if (char.IsDigit(item))
                    {
                        ConsoleSupport.PrintError("Your name cannot include any digits");
                        invalidName = true;
                        break;
                    }
                    else if (char.IsSymbol(item))
                    {
                        ConsoleSupport.PrintError("Your name cannot include any symbols");
                        invalidName = true;
                        break;
                    }
                    else if (char.IsPunctuation(item))
                    {
                        ConsoleSupport.PrintError("Your name cannot include any punctuation");
                        invalidName = true;
                        break;
                    }
                    else if (name == string.Empty)
                    {
                        ConsoleSupport.PrintError("Your name cannot be nothing");
                        invalidName = true;
                        break;
                    }
                }
                if (invalidName == false)
                {
                    break;
                }
            }
            name.ToLower();
            return char.ToUpper(name[0]) + name.Substring(1);
        }

        public static int CreateAge()
        {
            while (true)
            {
                ConsoleSupport.SpareLine(2);
                bool invalidAge = false;
                Console.WriteLine("What will your age be?");
                Console.Write("--> ");
                var ageUserInput = Console.ReadLine();

                var isNumeric = int.TryParse(ageUserInput, out int age);

                if (isNumeric)
                {
                    if (age < 0)
                    {
                        ConsoleSupport.SpareLine(1);
                        ConsoleSupport.PrintError("You haven't been born yet!");
                        invalidAge = true;
                    }
                    else if (age < 18)
                    {

                        ConsoleSupport.SpareLine(1);
                        ConsoleSupport.PrintError("Your age cannot be lower than 18");
                        invalidAge = true;
                    }
                    else if (age > 80)
                    {

                        ConsoleSupport.SpareLine(1);
                        ConsoleSupport.PrintError("Your age cannot be higher than 80");
                        invalidAge = true;
                    }
                }
                else
                {
                    invalidAge = true;
                }

                if (invalidAge == false)
                {
                    return age;
                }
            }
        }

        public static string CreateJob()
        {
            List<Job> jobs = new List<Job>();

            jobs.Add(new Job("Developer", 1));
            jobs.Add(new Job("Teacher", 2));
            jobs.Add(new Job("Plumber", 3));
            jobs.Add(new Job("electrician", 4));
            jobs.Add(new Job("Accountant", 5));
            jobs.Add(new Job("Chef", 6));
            jobs.Add(new Job("Real Estate Agent", 7));
            jobs.Add(new Job("FireFighter", 8));
            jobs.Add(new Job("Butcher", 9));
            jobs.Add(new Job("Police Officer", 10));

            while (true)
            {
                int i = 0;

                ConsoleSupport.SpareLine(3);
                Console.WriteLine("What will your job be? : ");
                ConsoleSupport.SpareLine(2);

                foreach (var job in jobs)
                {
                    i++;
                    job.Index = i;
                    Console.WriteLine(job.JobName + $" [{job.Index}]");
                }

                Console.Write("-> ");
                string userJobIndex = Console.ReadLine();

                var jobName = string.Empty;

                switch (userJobIndex)
                {

                    case "1":
                        jobName = jobs[0].JobName;
                        break;

                    case "2":
                        jobName = jobs[1].JobName;
                        break;

                    case "3":
                        jobName = jobs[2].JobName;
                        break;

                    case "4":
                        jobName = jobs[3].JobName;
                        break;

                    case "5":
                        jobName = jobs[4].JobName;
                        break;

                    case "6":
                        jobName = jobs[5].JobName;
                        break;

                    case "7":
                        jobName = jobs[6].JobName;
                        break;

                    case "8":
                        jobName = jobs[7].JobName;
                        break;

                    case "9":
                        jobName = jobs[8].JobName;
                        break;

                    case "10":
                        jobName = jobs[9].JobName;
                        break;

                    default:
                        ConsoleSupport.PrintError("Pick a valid option");
                        continue;
                }
               return jobName;

            }
        }
    }
}
