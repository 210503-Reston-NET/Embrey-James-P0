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
        private ICustomerBL _customerBL;
        private IVerificationService _verify;

        public ProductMenu(IOrderBL orderBL, ICustomerBL customerBL, IVerificationService verify)
        {
            _orderBL = orderBL;
            _customerBL = customerBL;
            _verify = verify;
        }
        public void Start()
        {
            int GetCustomerId = AddCustomer();
            Random nums = new Random();
            int ID = nums.Next(1111,9999);
            Orders newOrder = new Orders(ID, 0, GetCustomerId, 0, "PA");
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
                    int Quant1 = 1;
                    newOrder.OrderQuantity = newOrder.OrderQuantity + Quant1;
                    double Price1 = 9.00;
                    newOrder.OrderTotal = newOrder.OrderTotal + Price1;
                    _orderBL.UpdateOrder(newOrder);
                        Console.WriteLine("Purchased!");
                        break;
                    case "2":
                    int Quant2 = 1;
                    newOrder.OrderQuantity = newOrder.OrderQuantity + Quant2;
                    double Price2 = 10.00;
                    newOrder.OrderTotal = newOrder.OrderTotal + Price2;
                    _orderBL.UpdateOrder(newOrder);
                        Console.WriteLine("Purchased!");
                        break;
                    case "3":
                    int Quant3 = 1;
                    newOrder.OrderQuantity = newOrder.OrderQuantity + Quant3;
                    double Price3 = 10.00;
                    newOrder.OrderTotal = newOrder.OrderTotal + Price3;
                    _orderBL.UpdateOrder(newOrder);
                        Console.WriteLine("Purchased!");
                        break;
                    case "4":
                    int Quant4 = 1;
                    newOrder.OrderQuantity = newOrder.OrderQuantity + Quant4;
                    double Price4 = 12.00;
                    newOrder.OrderTotal = newOrder.OrderTotal + Price4;
                    _orderBL.UpdateOrder(newOrder);
                        Console.WriteLine("Purchased!");
                        break;
                    case "5":
                    int Quant5 = 1;
                    newOrder.OrderQuantity = newOrder.OrderQuantity + Quant5;
                    double Price5 = 12.00;
                    newOrder.OrderTotal = newOrder.OrderTotal + Price5;
                    _orderBL.UpdateOrder(newOrder);
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
        public int AddCustomer()
        {
                string names = _verify.VerifyString("Please enter your name:");
                string locales = _verify.VerifyString("Please enter your location:");
                Customers Harambe = new Customers(names, locales);
                bool customerExist = _customerBL.GetCustomer2(Harambe);
                if(!customerExist)
                {
                    Customers customerCreated = _customerBL.AddCustomer(Harambe);
                    Console.WriteLine("New customer created!");
                    return _customerBL.GetCustomer1(Harambe);
                }

                Console.WriteLine($"Welcome back {names}");

                return _customerBL.GetCustomer1(Harambe);
        }

    }
}