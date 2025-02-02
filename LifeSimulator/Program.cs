//                                                          Life Simulator
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
        Console.WriteLine($"Your name is {name}");
        Console.WriteLine($"Your age is {age}");


    }
}

