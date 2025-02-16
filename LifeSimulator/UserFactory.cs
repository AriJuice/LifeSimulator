using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        Console.WriteLine("You haven't been born yet!,");
                        invalidAge = true;
                    }
                    else if (age < 18)
                    {

                        ConsoleSupport.SpareLine(1);
                        Console.WriteLine("Your age cannot be lower than 18,");
                        invalidAge = true;
                    }
                    else if (age > 80)
                    {

                        ConsoleSupport.SpareLine(1);
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
                    return age;
                }
            }
        }
    }
}
