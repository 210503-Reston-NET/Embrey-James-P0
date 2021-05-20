using System.Collections.Generic;
using PPBL;
using PPDL;
using System;
using PPModels;

namespace PPUI
{
public class ProductMenu : IMenu
    {
        private IMenu submenu;

        private IOrderBL _orderBL;
        private IVerificationService _verify;

        public ProductMenu(IOrderBL orderBL, IVerificationService verify)
        {
            _orderBL = orderBL;
            _verify = verify;
        }
        public void Start()
        {
            Random nums = new Random();
            int ID = nums.Next(1111,9999);
            Orders newOrder = new Orders(ID, 0, 1, 9);
            Orders createdOrder = _orderBL.AddOrder(newOrder);

            bool repeat = true;
            do
            {
                Console.WriteLine("What sauce would you like to purchase?");
                Console.WriteLine("[0] Purchase Mango Twango (Mild) $9.00");
                Console.WriteLine("[1] Purchase Hickory Dickory (Mild) $9.00");
                Console.WriteLine("[2] Purchase Hollapeno (Medium) $10.00");
                Console.WriteLine("[3] Purchase Heat Wave (Medium $10.00");
                Console.WriteLine("[4] Purchase Scorpion Sting (Hot) $12.00");
                Console.WriteLine("[5] Purchase Pepper Plague (Hot) $12.00");
                Console.WriteLine("[6] Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                    int Quant = 1;
                    newOrder.OrderQuantity = newOrder.OrderQuantity + Quant;
                    double Price = 9.00;
                    newOrder.OrderTotal = newOrder.OrderTotal + Price;
                    _orderBL.UpdateOrder(newOrder);
                        Console.WriteLine("Purchased!");
                        break;
                    case "1":
                        Console.WriteLine("Purchased!");
                        break;
                    case "2":
                        Console.WriteLine("Purchased!");
                        break;
                    case "3":
                        Console.WriteLine("Purchased!");
                        break;
                    case "4":
                        Console.WriteLine("Purchased!");
                        break;
                    case "5":
                        Console.WriteLine("Purchased!");
                        break;
                    case "6":
                        Console.WriteLine("Have a nice day!");
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        submenu.Start();
                        break;
                }
            } while (repeat);
        }
    }
}