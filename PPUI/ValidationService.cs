using System;

namespace Models
{
    //generic validation service that validates general input, for specific validation rules, put those in model
    // properties
    public class ValidationService
    {
        
    }

    public int ValidateInt(string prompt)
    {
        int response = 0;
        bool repeat = true;
        do
        {
            Console.WriteLine(prompt);
            try
                {
                    //you can also run a regex so you're sure that Int32.Parse
                    response = Int32.Parse(Console.ReadLine());
                    if (response > -1)
                    {
                    repeat = false;
                    }
                    else
                    {
                        {
                            Console.WriteLine("Input must be non-negative");
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter an integer value.");
                }
            {
                
                throw;
            }
            response = Int32.TryParse(Console.ReadLine().ToCharArray());
        } while (repeat);
    }
}