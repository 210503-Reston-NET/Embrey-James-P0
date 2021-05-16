using System.Collections.Generic;
using PPBL;
using PPDL;
using System;

namespace PPUI
{
public class ProductMenu : IMenu
    {
        private IMenu submenu;
        public void Start()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("What sauce would you like to purchase?");
                Console.WriteLine("[0] Purchase Mango Twango (Mild)");
                Console.WriteLine("[1] Purchase Hickory Dickory (Mild)");
                Console.WriteLine("[2] Purchase Hollapeno (Medium)");
                Console.WriteLine("[3] Purchase Heat Wave (Medium");
                Console.WriteLine("[4] Purchase Scorpion's Sting (Hot)");
                Console.WriteLine("[5] Purchase Pepper Plague (Hot)");
                Console.WriteLine("[6] Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        Console.WriteLine("Purchased!");
                        submenu.Start();
                        break;
                    case "1":
                        Console.WriteLine("Purchased!");
                        submenu.Start();
                        break;
                    case "2":
                        Console.WriteLine("Purchased!");
                        submenu.Start();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        repeat = false;
                        break;
                }
            } while (repeat);
        }
    }
}