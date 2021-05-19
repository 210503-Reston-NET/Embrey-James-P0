using System;

namespace PPUI
{
    public class VerificationService : IVerificationService
    { 
    public string VerifyString(string prompt)
        {
            string response;
            bool repeat;
            do
            {
                Console.WriteLine(prompt);
                response = Console.ReadLine();
                repeat = String.IsNullOrWhiteSpace(response);
                if (repeat) Console.WriteLine("Please input a non empty string");
            } while (repeat);
            return response;
        }
    }
}