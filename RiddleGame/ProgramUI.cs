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
        //public enum { E, C, H, O }
        public List<string> _lettersList = new List<string>();
        public void Run()
        {
            Menu();
        }
        public void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;  
                Console.Clear();
                Console.WriteLine("\n\tWelcome to the Riddle Game! I will give you a riddle, you have to solve the riddle by going down each path and collecting letters to help you find the answer!\n\n\t\tHere is your riddle:\n\n~~~I speak without a mouth and hear without ears. I have no body, but I come alive with wind. What am I??~~~\n\nChoose from the menu options below by typing the number path you'd like to go down.\n\tMenu:\n\t\tPath 1\n\t\tPath 2\n\t\tPath 3\n\t\tPath 4\n\t\t5. See aquired letters\n\t\t6. Guess Riddle\n\t\t7. Exit");

                string userInput = Console.ReadLine();
                if (_lettersList.Contains("C") && _lettersList.Contains("E") && _lettersList.Contains("H") && _lettersList.Contains("O"))
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\tYou have all the letters needed for the answer! Press any key to go to main menu and make your guess!");
                    Console.WriteLine("\n\tYou aquired the following:\n\n");
                    _lettersList.ForEach(Console.WriteLine);
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
            Console.WriteLine("You found another riddle!\nWhat time is it when an elephant sits on your fence?\n\n1. Time to get a new fence\n2. Time to get a new elephant\nChoose your answer with a 1 or 2\n");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.Clear();
                Console.WriteLine("You better get a new fence, an maybe a new neighborhood, that extremely rude elephant just sat on your fence and it's now broken!!\n\nYou get a 'C'!!\n\nPress any key to go to main menu");
                if(!_lettersList.Contains("C"))_lettersList.Add("C");
                Console.ReadKey();
            }
            else if (userInput == "2")
            {
                Console.Clear();
                Console.WriteLine("You certainly need a new, not so rude elephant, but no letter for you! Go back and try again!\n\nPress any key to go to main menu");
                Console.ReadKey();
                PathOne();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Choose either a 1 or a 2!!\n\nPress any key to go to main menu");
                Console.ReadKey();
                PathOne();

            }
        }
        public void PathTwo()
        {
            Console.Clear();
            Console.WriteLine("What gets wet while it dries\n\n1. A cup of water\n2. A Towel\nChoose your answer with a 1 or 2\n");

            string command = Console.ReadLine();

            if (command == "2")
            {
                Console.Clear();
                Console.WriteLine("I know my towels get wet, how about yours?? Here's an 'O'!! Not to be confused with a 0!\n\nPress any key to go to main menu");
                if(!_lettersList.Contains("O"))_lettersList.Add("O");
                Console.ReadKey();
            }
            else if (command == "1")
            {
                Console.Clear();
                Console.WriteLine("Water?? Come on, you know that's just silly!!\n\nPress any key to go to main menu");
                Console.ReadKey();
                PathTwo();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ooops! No! I think you know what to choose now\n\nPress any key to go to main menu");
                Console.ReadKey();
                PathTwo();

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
                PathThree();
            }
            else if (userInput == "2")
            {
                Console.Clear();
                Console.WriteLine("That's right! You CAN hold someone else's left hand, but not your own! you get a 'E'!!!\n\nPress any key to go to main menu");
                if(!_lettersList.Contains("E"))_lettersList.Add("E");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please choose either a 1 or a 2!\n\nPress any key to go to main menu");
                Console.ReadKey();
                PathThree();
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
                    if(!_lettersList.Contains("H"))_lettersList.Add("H");
                    Console.ReadKey();
                }
                else if (command == null)
                {
                    Console.Clear();
                    Console.WriteLine("Choose one of the options: 1 or 2?\n\nPress any key to go to main menu");
                    PathFour();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ooops! Not correct! I think you know what to choose now\n\nPress any key to go to main menu");
                    Console.ReadKey();
                    PathFour();
                }
            }
        }
        public void SeeAquiredLetters()
        {
            Console.Clear();
            if (_lettersList.Count == 0)
            {
                    Console.Clear();
                    Console.WriteLine("\t\n You thought you solved the riddles? Not yeeet! Go back and solve some, and earn letters." +
                        $"\n\n\n\nPress any key to go to the main menu...");
                    Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\t\nYou acquired the followings:\n\n");
                _lettersList.ForEach(Console.WriteLine);
                Console.WriteLine("\n\nPress any key to go to the main menu...");
                Console.ReadKey();
            }
        }

        public void GuessRiddle()
        {
            Console.Clear();
            //Console.WriteLine("What is your guess to the riddle?\n\nHere are the letters you aquired:\n");
            foreach (string letterAquired in _lettersList)
            {
                //Console.WriteLine(letterAquired);
            }
            //Console.WriteLine(string.Join(", ",_lettersList));
            Console.WriteLine("\nI speak without a mouth and hear without ears. I have no body, but I come alive with wind. What am I??");
            string command = Console.ReadLine().ToLower();

            if (command == "echo")
            {
                Console.Clear();
                Console.WriteLine("Wow! You are AMAZING!\n\nPress any key to go to main menu");
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
