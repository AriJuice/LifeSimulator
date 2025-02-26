namespace LifeSimulator
{
    internal class MainProgram
    {
        static void Main()
        {
            string name = UserFactory.CreateName();
            Console.Clear();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            int age = UserFactory.CreateAge();
            Console.Clear();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            string jobName = UserFactory.CreateJob();
            Console.Clear();
            User user = new User(name, age, jobName, 0);
            Console.WriteLine("Press any key to continue...");


            int choice = MenuManager.MakeMenu("What would you like to do?",
                                              "Go to work NOT WORKING","Go outside NOT WORKING","Go on the computer NOT WORKING");

            switch (choice) 
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;
            }


        }
    }
}
