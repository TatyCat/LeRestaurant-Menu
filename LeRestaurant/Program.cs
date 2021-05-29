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
            Menu.scrubInput(menuObj.menuInput);
            Console.WriteLine("Selected Menu: " + menuObj.menuInput);

        }

        public static void scrubInput(string input)
        {
        }

        public static void selectMenu(string input)//call menu based on input
        {
            //switch (input)
            //{

            //};
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
