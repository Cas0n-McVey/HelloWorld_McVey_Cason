 // System namespace need to use Console class.
  using System;
 // My collection of classes for this project.
namespace HelloWorld_Cason_McVey
{

    // Main class for this program
    class Program
    {
        // The Main method is executed when application starts
        static void Main(string[] args)
        {
            // Asks the user for their first name
            Console.WriteLine("What is your first name?");
            // Assigns user input to firstName variable
            string firstName = Console.ReadLine();
            // Asks the user for their last name
            Console.WriteLine("What is your last name?");
            // Assigns user input to lastName variable
            string lastName = Console.ReadLine();

            // Prints a welcome message with firstName and lastName
            Console.WriteLine($"Hello, {firstName} {lastName}!");
        }
    }
}
