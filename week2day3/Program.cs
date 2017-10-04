using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 10; i > 0; i-- ) //this is counting backwards.
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Do you want to play again? (YES/NO)");
            //string playAgain = Console.ReadLine().ToUpper();

            //while (playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? (YES/NO)");
            //    playAgain = Console.ReadLine().ToUpper();
            //}


            //Check in System
            Console.WriteLine("Would you like to check in for your appointment? (YES/NO)");
            string checkin = Console.ReadLine().ToLower();

            while (checkin == "yes")
            {
                Console.WriteLine("PATIENT CHECK IN SYSTEM");
                Console.WriteLine("Please print your full name.");
                string name = (Console.ReadLine());
                Console.WriteLine("Please enter your 6-digit patient ID");
                int digit = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your appointment time.");
                string time = (Console.ReadLine());
                Console.WriteLine(name + " is checked in for their " + time + " appointment.");
                Console.WriteLine("Would you like to check in for your appointment? (YES/NO)");
                checkin = Console.ReadLine().ToLower();
            }

            //DO While
            string playAgain;
            do
            {
                Console.WriteLine("Let's play a game!");
                Console.ReadLine();  
                Console.WriteLine("Great game!");
                Console.WriteLine("Do you want to play the game again? (YES/NO)");
                playAgain = Console.ReadLine().ToLower().Trim();
            }
            while (playAgain == "yes" || playAgain == "yes!");

            Console.WriteLine("Thanks for playing the game.");





            //GPA calculation
            //Console.WriteLine("Would you like GPA calculation? (YES/NO)");
            //string gpaConsent = Console.ReadLine().ToUpper();

            //while (gpaConsent == "YES")
            //{
            //    Console.WriteLine("What is your letter grade for the class? (No +/-, please)");
            //    Console.ReadLine();
            //    Console.WriteLine("Do you have another class you'd like to add? (YES/NO)");
            //    gpaConsent = Console.ReadLine().ToUpper();
            //}







        }
    }
}
