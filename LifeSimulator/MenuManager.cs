using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSimulator
{
    internal class MenuManager
    {
        public static int MakeMenu(string heading, string text1 = "n", string text2 = "n",
            string text3 = "n",string text4 = "n", string text5 = "n")
        {
            List<string> menuTexts = new List<string>();
            menuTexts.Clear();
            menuTexts.Add(text1);
            menuTexts.Add(text2);
            menuTexts.Add(text3);
            menuTexts.Add(text4);
            menuTexts.Add(text5);

            List<string> RemoveList = new List<string>();
            

            while (true)
            {

                ConsoleSupport.SpareLine(2);

                Console.WriteLine(heading);
                int i = 0;
                RemoveList.Clear();
                foreach (string s in menuTexts)
                {
                    if (s.ToLower() != "n")
                    {
                        i++;
                        Console.WriteLine(s + $" [{i}]");
                    }
                    else
                    {
                        RemoveList.Add(s);
                    }
                }
                
                Console.Write("-> ");
                string userChoiceStr = Console.ReadLine();
                bool isOptionNum = int.TryParse(userChoiceStr, out int userChoice);

                if (!isOptionNum)
                {
                    ConsoleSupport.PrintError("Your choice should be a number");
                    continue;
                }

                foreach (string s in RemoveList)
                {
                    if (menuTexts.Contains(s))
                    {
                        menuTexts.Remove(s);
                    }
                }

                if (userChoice > 0 && userChoice < menuTexts.Count() + 1)
                {
                    return userChoice;
                }
                else
                {
                    ConsoleSupport.PrintError("Your choice should be in the valid range");
                    continue;
                }
            }
        }
    }
}
