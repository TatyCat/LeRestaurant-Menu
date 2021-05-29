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
                        selected.breakfastMenu();
                        break;
                    case 2:
                        break;
                    case 3:

                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter 1, 2, or 3");
                Menu menuObj = new Menu();
                menuObj.menuInput = Console.ReadLine();

            };


            //Console.WriteLine("Selected Menu: " + cleanedInput);

        }
    }


    public class AllMenus
    {
        public void breakfastMenu()
        {
            Console.WriteLine("BreakfastMenu");

            //Dictionary<string, double> breakfast = new Dictionary<string, double>
            //{
            //   {"Apples", 3.75},
            //   {"Apples", 3.75},
            //   {"Apples", 3.75}
            //};
        }
    }

    public class LunchMenu { }

    public class DinnerMenu { }

}
