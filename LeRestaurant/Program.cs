using System;
using System.Collections.Generic;
using System.Text;

namespace LeRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue au restaurant!");
            Menu.menuHomeScreen();
        }
    }

    public class Menu
    {
        string menuInput;

        public static void menuHomeScreen()
        {
            Menu menuObj = new Menu();

            Console.WriteLine("Which menu will you be needing?");
            Console.WriteLine("Enter 1 for Breakfast");
            Console.WriteLine("Enter 2 for Lunch");
            Console.WriteLine("Enter 3 for Dinner");

            menuObj.menuInput = Console.ReadLine();
            Menu.selectMenu(menuObj.menuInput);
        }

        public static void selectMenu(string input)
        {
            int cleanedInput = Convert.ToInt32(input);

            if (cleanedInput == 1 || cleanedInput == 2 || cleanedInput == 3)
            {
                AllMenus selected = new AllMenus();
                switch (cleanedInput)
                {
                    case 1:
                        selected.BreakfastMenu();
                        break;
                    case 2:
                        selected.LunchMenu();
                        break;
                    case 3:
                        selected.DinnerMenu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please try again by entering 1, 2, or 3");
                Console.WriteLine();
                menuHomeScreen();
            };
        }
    }


    public class AllMenus
    {
        public void BreakfastMenu()
        {
            Console.WriteLine("BreakfastMenu");
        }

        public void LunchMenu()
        {
            Console.WriteLine("lunch Menu");

        }

        public void DinnerMenu()
        {
            Console.WriteLine("Dinner Menu");

        }
    }
}
