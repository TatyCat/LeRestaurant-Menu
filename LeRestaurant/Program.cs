using System;
using System.Collections.Generic;

namespace LeRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue au restaurant!");
            Menu.MenuHomeScreen();

        }
    }

    public class Menu
    {
        public static void MenuHomeScreen()
        {
            Console.WriteLine("Which menu will you be needing?");
            Console.WriteLine("Enter 1 for Breakfast");
            Console.WriteLine("Enter 2 for Lunch");
            Console.WriteLine("Enter 3 for Dinner");

            string menuinput = Console.ReadLine();
            Console.WriteLine("Selected Menu: " + menuinput);

        }
    }

    public class BreakfastMenu
    {
        //Dictionary<string, double> breakfast = new Dictionary<string, double>
        //{
        //   {"Apples", 3.75},
        //   {"Apples", 3.75},
        //   {"Apples", 3.75}
        //};
    }

    public class LunchMenu { }

    public class DinnerMenu { }

}
