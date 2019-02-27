using System;

namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point
        static void Main(string[] args)
        {
            GetAppInfo(); // GetAppInfo function...
            GreetUser(); // Ask for username and greet

            while (true)
            {

                // Create a random number
                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                //Initialize guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");


                // While guess is not correct
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //Make sure a number is entered...
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red,"Please use an actual number");
                       
                        //Keep going...
                        continue;
                    }

                    // cast to an int and put in guess variable
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    { 
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again...");
                    }
                }
                //Success Message

                // Print error message
                PrintColorMessage(ConsoleColor.Yellow, "YOU ARE CORRECT!!!");

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                    else;
                {
                    return;
                }        
            }
        }
        // Get and display app info...
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "John Sticher";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write app info...


            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

        }

        // Ask for username and greet...
        static void GreetUser()
        {
            //Ask username
            Console.WriteLine("What is your name?");

            //Get input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, would you like to play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message) 
        {
            // Change text color
            Console.ForegroundColor = color;

            // Not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
