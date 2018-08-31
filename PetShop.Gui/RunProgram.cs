using Bomholt.PetShop.UI.InterF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Bomholt.PetShop.UI
{
    public class RunProgram : IRunProgram
    {
        private ILogic logic;

        public RunProgram(ILogic logic)
        {
            this.logic = logic;
        }
        public void Run()
        {
            Console.WriteLine("VIDEO CONSOLE MENU");
        //Show list of choices(*Optional, Pure UI, Add one choice at a time)
        //Show list of all Pets
        //Search Pets by Type(Cat, Dog, Goat etc.maybe as Enum) * Yes Goats can be pets :D
        //Create a new Pet
        //Delete Pet
        //Update a Pet
        //Sort Pets By Price
        //Get 5 cheapest available Pets
            bool on = true;
            do
            {
                switch (PrintMenu())
                {
                    case 1:
                        Console.WriteLine("You chose: ");
                        break;
                    case 2:
                        Console.WriteLine("You chose: Search Pets by Type");
                        break;
                    case 3:
                        Console.WriteLine("You chose: Create a new Pet");
                        break;
                    case 4:
                        Console.WriteLine("You chose: Delete Pet");
                        break;
                    case 5:
                        Console.WriteLine("You chose: Update a Pet");
                        break;
                    case 6:
                        Console.WriteLine("You chose: Sort Pets By Price");
                        break;
                    case 7:
                        Console.WriteLine("You chose: Get 5 cheapest available Pets");
                        break;
                    case 8:
                         logic.Exit();
                        on = false;
                        break;
                }
            } while (on);
        }

        public int PrintMenu()
        {
            string[] MenuItems = { "Show list of all Pets", "Search Pets by Type", "Create a new Pet", "Delete Pet", "Update a Pet", "Sort Pets By Price", "Get 5 cheapest available Pets", "Exit" };
            int Select;
            Console.WriteLine();
            for (int i = 0; i < MenuItems.Length; i++)
            {
                Console.WriteLine($"{i + 1} | {MenuItems[i]}");
            }

            do
            {
                Console.Write("Select 1-8 and press enter: ");
            } while (!int.TryParse(Console.ReadLine(), out Select) || Select > 8 || Select < 1);
            return Select;
        }

        
    }
}
