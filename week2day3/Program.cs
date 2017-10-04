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


            ////Check in System
            //Console.WriteLine("Would you like to check in for your appointment? (YES/NO)");
            //string checkin = Console.ReadLine().ToLower();

            //while (checkin == "yes")
            //{
            //    Console.WriteLine("PATIENT CHECK IN SYSTEM");
            //    Console.WriteLine("Please print your full name.");
            //    string name = (Console.ReadLine());
            //    Console.WriteLine("Please enter your 6-digit patient ID");
            //    int digit = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Please enter your appointment time.");
            //    string time = (Console.ReadLine());
            //    Console.WriteLine(name + " is checked in for their " + time + " appointment.");
            //    Console.WriteLine("Would you like to check in for your appointment? (YES/NO)");
            //    checkin = Console.ReadLine().ToLower();
            //}

            ////DO While
            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Let's play a game!");
            //    Console.ReadLine();  
            //    Console.WriteLine("Great game!");
            //    Console.WriteLine("Do you want to play the game again? (YES/NO)");
            //    playAgain = Console.ReadLine().ToLower().Trim();
            //}
            //while (playAgain == "yes" || playAgain == "yes!");

            //Console.WriteLine("Thanks for playing the game.");



            //GPA calculation
            Console.WriteLine("Would you like GPA calculation?");
            string gpaConsent = Console.ReadLine().ToUpper();

            double gpa = 0;
            int classes = 0;
            double totgpa = 0;

            do
            {
                Console.WriteLine("What is your letter grade for the class? (No +/-, please)");
                string letterGrade = Console.ReadLine().ToLower().Trim(); 

                switch (letterGrade)
                {
                    case "a":
                        gpa = 4.0;
                        break;
                    case "b":
                        gpa = 3.0;
                        break;
                    case "c":
                        gpa = 2.0;
                        break;
                    case "d":
                        gpa = 1.0;
                        break;
                    case "f":
                        gpa = 0.0;
                        break;
                    default:
                        Console.WriteLine("Please write your class letter grade.");
                        continue;
                        break;
                }
                totgpa = totgpa + gpa;
                Console.WriteLine("Do you have another class you'd like to add? (YES/NO)");
                gpaConsent = Console.ReadLine().ToUpper().Trim();
                classes++;
            }
            while (gpaConsent == "YES");

            double averageGpa = totgpa / classes;
            Console.WriteLine("Your GPA is " + averageGpa);


            ////this is called "Continue"
            //for (int i = 0; i < 20; i++) //this is running 20 times. if we did i+=2 then it will run 10 times.
            //{
            //    //let's say we want it to run 20 times, but only print out the odd numbers. How can we do it?
            //    if(i % 2 == 0)
            //    {
            //        continue; //stops the loop right where it is, and sends it back to start! will not finish the loop!
            //    }
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 20; i++) 
            //{                
            //    if (i % 13 == 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("The loop is done. It's tired. It's exhausted. Don't ask again today.");

            //for(int i = 1; i <= 4; i++) //responsible for rows.
            //{
            //    for (int j = 1; j <= 8; j++)
            //    {
            //        Console.Write(j); //columns
            //    }
            //    Console.WriteLine(); //next row
            //}

            //Console.WriteLine();

            ////nested loops you could also...
            //int n = int.Parse(Console.ReadLine());
            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 1; col <= row; col++)
            //    {
            //        Console.Write(col + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Methods




        }
    }
}
