using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PPBL;
using PPDL;

namespace PPUI
{
    public class Intro
    {
    public static IMenu GetMenu(string menuType)
        {
            switch (menuType.ToLower())
            {
                case "homescreen":
                    return new HomeScreen();
                case "customer":
                    return new CustomerMenu();
                case "productmenu":
                    return new ProductMenu();
                case "managermenu":
                    return new ManagerMenu();
                default:
                    return null;
            }
        }
    }
}