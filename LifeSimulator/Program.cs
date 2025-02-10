//                                                          Life Simulator
using LifeSimulator;

class Program
{
    static void SpareLine(int lines)
    {
        for (int i = 0; i <= lines; i++)
        {
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.WriteLine("            |--------------|          ");
        Console.WriteLine("            |Life Simulator|          ");
        Console.WriteLine("            |--------------|          ");

        SpareLine(1);
        string name = string.Empty;
        bool invalidName = false;

        while (true)
        {
            SpareLine(2);
            invalidName = false;
            Console.WriteLine("What will your name be?");
            Console.Write("--> ");
            name = Console.ReadLine();

            foreach (var item in name)
            {
                if (name.Contains(" "))
                {
                    SpareLine(1);
                    Console.WriteLine("Your name cannot include any white-spaces,");
                    invalidName = true;
                    break;
                }
                else if (char.IsDigit(item))
                {
                    SpareLine(1);
                    Console.WriteLine("Your name cannot include any digits,");
                    invalidName = true;
                    break;
                }
                else if (char.IsSymbol(item))
                {
                    SpareLine(1);
                    Console.WriteLine("Your name cannot include any symbols,");
                    invalidName = true;
                    break;
                }
                else if (char.IsPunctuation(item))
                {
                    SpareLine(1);
                    Console.WriteLine("Your name cannot include any punctuation,");
                    invalidName = true;
                    break;
                }
                else if (name == string.Empty)
                {
                    SpareLine(1);
                    Console.WriteLine("Your name cannot be nothing,");
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
        name = char.ToUpper(name[0]) + name.Substring(1);
        
        string ageUserInput;
        int age = 0;

        SpareLine(1);

        while (true)
        {
            bool invalidAge = false;

            SpareLine(2);
            invalidName = false;
            Console.WriteLine("What will your age be?");
            Console.Write("--> ");
            ageUserInput = Console.ReadLine();

            var isNumeric = int.TryParse(ageUserInput, out age);

            if (isNumeric)
            {
                if (age < 0)
                {
                    SpareLine(1);
                    Console.WriteLine("You haven't been born yet!,");
                    invalidAge = true;
                }
                else if (age < 18)
                {

                    SpareLine(1);
                    Console.WriteLine("Your age cannot be lower than 18,");
                    invalidAge = true;
                }
                else if (age > 80)
                {

                    SpareLine(1);
                    Console.WriteLine("Your age cannot be higher than 80,");
                    invalidAge = true;
                }
            }
            else
            {
                invalidAge = true;
            }

            if (invalidAge == false)
            {
                break;
            }
        }

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
        



        int i = 0;

        while (true)
        {
            SpareLine(3);
            Console.WriteLine("What will your job be? : ");
            SpareLine(2);

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
                    continue;
            }
            User user = new User(name,age,jobName);
            Console.WriteLine($"Yoour name is {user.Name}, You are {user.Age} years old" +
                              $" and your profession is a {user.Job}!");
            break;
        }
        
    }
}

