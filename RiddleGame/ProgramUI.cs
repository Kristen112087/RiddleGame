using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RiddleGame
{
    public class ProgramUI
    {

        public List<string> _guess = new List<string>();
        

        public void Run()
        {
            Menu();
        }

        public void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Riddle Game! I will give you a riddle to solve. Solve the riddle by going down each path and collecting letters to help you find the answer!\n\nHere is your riddle:\n\nI speak without a mouth and hear without ears. I have no body, but i come alive with wind. What am I??\n\nChoose from the menu options below by typing the number path you'd like to go down.\nMenu:\nPath 1\nPath 2\nPath 3\nPath 4\n5. See aquired letters\n6. Guess Riddle\n7. Exit");

                string userInput = Console.ReadLine();
                if (_guess.Contains("C") && _guess.Contains("E") && _guess.Contains("H") && _guess.Contains("O"))
                {
                    Console.WriteLine("You have all the letters needed for the answer! Press any key to go to main menu and make your guess!");
                    Console.ReadKey();
                }


                switch (userInput)
                {
                    case "1":
                        PathOne();
                        break;
                    case "2":
                        PathTwo();
                        break;
                    case "3":
                        PathThree();
                        break;
                    case "4":
                        PathFour();
                        break;
                    case "5":
                        SeeAquiredLetters();
                        break;
                    case "6":
                        GuessRiddle();
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine("Enter a valid number");
                        break;
                }
            }
        }

        public void PathOne()
        {

            Console.Clear();
            Console.WriteLine("You found another riddle!\nWhat time is it when en elephant sits on your fence?\n\n1. Time to get a new fence\n2. Time to get a new elephant\nChoose your answer with a 1 or 2\n");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.Clear();
                Console.WriteLine("You better get a new fence, yours is broken!!\n\nYou get a 'C'!!\n\nPress any key to go to main menu");
                _guess.Add("C");
                Console.ReadKey();
            }
            else if (userInput == "2")
            {
                Console.Clear();
                Console.WriteLine("You certainly need a new, not so rude elephant, but no leter for you! Go back and try again!\n\nPress any key to go to main menu");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Choose either a 1 or a 2!!\n\nPress any key to go to main menu");
                Console.ReadKey();

            }


        }
        public void PathTwo()
        {
            Console.Clear();
            Console.WriteLine("What gets wet while drying\n\n1. Water\n2. A Towel\nChoose your answer with a 1 or 2\n");

            string command = Console.ReadLine();

            if (command == "2")
            {
                Console.Clear();
                Console.WriteLine("Sure! I hope you know why. Just kidding. Of course you know! As an award, I will give you a letter, which is 'O'. Not zero!\n\nPress any key to go to main menu");
                _guess.Add("O");
                Console.ReadKey();
            }
            else if (command == "1")
            {
                Console.Clear();
                Console.WriteLine("Choose one of the options: 1 or 2?\n\nPress any key to go to main menu");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ooops! No! I think you know what to choose now\n\nPress any key to go to main menu");
                Console.ReadKey();

            }

        }
        public void PathThree()
        {
            Console.Clear();
            Console.WriteLine("What can you hold in your right hand, but never in your left hand?\n\n1. A right handed pencil\n2. Your left hand\nChoose your answer with a 1 or 2\n");

            string userInput = Console.ReadLine().ToLower();

            if (userInput == "1")
            {
                Console.Clear();
                Console.WriteLine("Are there really right and left handed pencils O_o?? Try again!!\n\nPress any key to go to main menu");
                Console.ReadKey();
            }
            else if (userInput == "2")
            {
                Console.Clear();
                Console.WriteLine("That's right! You CAN hold someone else's left hand, but not your own! you get a 'E'!!!\n\nPress any key to go to main menu");
                _guess.Add("E");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please choose either a 1 or a 2!\n\nPress any key to go to main menu");
                Console.ReadKey();

            }


        }
        public void PathFour()
        {
            Console.Clear();
            Console.WriteLine("What can you catch, but not throw?\n\n1. A cold\n2. a REEEEEEEALLY heavy ball\nChoose your answer with a 1 or 2\n");
            {
                string command = Console.ReadLine().ToLower();

                if (command == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Smart! I doubted that you would guess it...kidding...I have a surprise for you. Letteeeeeeer: 'H'!\n\nPress any key to go to main menu");
                    _guess.Add("H");
                    Console.ReadKey();
                }
                else if (command == null)
                {
                    Console.Clear();
                    Console.WriteLine("Choose one of the options: 1 or 2?\n\nPress any key to go to main menu");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ooops! Not correct! I think you know what to choose now\n\nPress any key to go to main menu");
                    Console.ReadKey();
                }

            }
        }
        public void SeeAquiredLetters()
        {
            Console.Clear();
            foreach (string letterAquired in _guess)
             
            {
                _guess.ToArray
                Console.WriteLine($"You have aquired the letter(s) " + letterAquired + " press any key to coninue");
                Console.ReadLine();
            }


        }
        public void GuessRiddle()
        {
            Console.Clear();
            Console.WriteLine("What is your guess to the riddle?\n\nI speak without a mouth and hear without ears. I have no body, but i come alive with wind. What am I??");
            string command = Console.ReadLine().ToLower();

            if (command == "echo")
            {
                Console.Clear();
                Console.WriteLine("Wow! You are AMAZING!\n\nPress any key to go to main menu\n\nPress any key to go to main menu");
                Console.ReadKey();
            }
            else if (command == null)
            {
                Console.Clear();
                Console.WriteLine("Ooops! Try again!\n\nPress any key to go to main menu");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I thought you said you wanted to guess!\n\nPress any key to go to main menu");
                Console.ReadKey();
            }

        }















    }
}
