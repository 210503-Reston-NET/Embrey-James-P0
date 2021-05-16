using System;
using PPDL;
using PPBL;
namespace PPUI
{
    public class ManagerMenu : IMenu
    {
        private IMenu submenu;
        public void Start()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("Welcome back Manager! What would you like to do?");
                Console.WriteLine("[0] View Inventory");
                Console.WriteLine("[1] View Customers");
                Console.WriteLine("[2] Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        submenu = Intro.GetMenu("Inventory");
                        submenu.Start();
                        break;
                    case "1":
                        submenu = Intro.GetMenu("Customers");
                        submenu.Start();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }
            } while (repeat);
        }
    }
}