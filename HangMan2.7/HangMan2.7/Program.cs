using System;
using System.Collections;
using System.Linq;

namespace HangMan
{
    class Program
    {
        static void Main(string[] rgs)

        {

            Console.ForegroundColor = ConsoleColor.Cyan;


            ArrayList WordList = new ArrayList();
            WordList.Add("elephant");
            WordList.Add("monkey");
            WordList.Add("hello");
            WordList.Add("hi");
            WordList.Add("hangman");
            WordList.Add("computer");
            WordList.Add("fly");
            WordList.Add("apple");
            WordList.Add("pencil");
            WordList.Add("floor");
            WordList.Add("bear");
            WordList.Add("dog");
            WordList.Add("ghost");
            WordList.Add("program");
            WordList.Add("table");
            WordList.Add("rope");
            WordList.Add("clock");
            WordList.Add("book");
            WordList.Add("paint");
            WordList.Add("projector");
            WordList.Add("map");
            WordList.Add("cardboard");
            WordList.Add("brick");
            WordList.Add("crown");
            WordList.Add("flag");
            WordList.Add("windows");
            WordList.Add("Linux");
            WordList.Add("iusearchbtw");
            WordList.Add("tree");
            WordList.Add("globe");
            WordList.Add("alphabet");
            WordList.Add("debian");
            WordList.Add("ubuntu");
            WordList.Add("mint");
            WordList.Add("arch");
            WordList.Add("kali");
            WordList.Add("fedora");
            WordList.Add("gentoo");
            WordList.Add("redhat");
            WordList.Add("pseudopseudohypoparathyroidism");
            WordList.Add("pneumonoultramicroscopicsilicovolcanoconiosis");


            Console.WriteLine();
            Console.WriteLine("Welcome to HangMan!!!\n");

            System.Threading.Thread.Sleep(1500);

            Console.WriteLine("The rules are very simple. The program selects a random word and you will be able to guess one letter.\n");

            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("If you guessed correctly, the letter in the word will be filled in.");
            Console.WriteLine("But if you guessed wrong, one life will be taken away.");

            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("Be careful! You have only 7 lives.\n");

            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("If you have 0 lives, you lose and then you can decide if you want to quit or continue playing.\n\n\n");



            bool GameIsRunning = true;

            do
            {
                Random random = new Random();
                int index = random.Next(0, WordList.Count);
                string word = (string)WordList[index];


                Console.WriteLine("    __________");
                Console.WriteLine("    |/       |");
                Console.WriteLine("    |        o");
                Console.WriteLine("    |       /O\\");
                Console.WriteLine("    |       / \\");
                Console.WriteLine(" _________ ");
                Console.WriteLine(" \\_______/");
                Console.WriteLine();

                int wordlength = word.Length;
                char[] stars = new char[wordlength];

                for (int i = 0; i < wordlength; i++)
                {
                    stars[i] = '*';
                }

                char[] letters = word.ToCharArray();

                int lifes = 7;
                word.ToCharArray();

                while (lifes > 0)
                {

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("The guessed word is: ");
                    Console.WriteLine(stars);
                    Console.Write("Guess the letter: ");
                    string letter = Console.ReadLine().ToLower();
                    char[] lettertest = letter.ToCharArray();
                    char NewLetter = lettertest[0];
                    bool player = word.All(Char.IsLetter);

                    while (player == false || letter.Length != 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.WriteLine();
                        Console.WriteLine("Please enter just one letter.");
                        Console.Write("Guess the letter: ");
                        letter = Console.ReadLine();
                        player = letter.All(Char.IsLetter);
                    }

                    if (word.Contains(NewLetter))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        int LetterIndex = word.IndexOf(NewLetter);
                        stars[LetterIndex] = NewLetter;
                    }

                    if (NTZH(stars))
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        string txt = "You Won!!!";
                        BlinkinkText(txt, 500);

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.WriteLine();
                        Console.WriteLine("The guessing word was: " + word);
                        Console.WriteLine();
                        Console.WriteLine("Do you want play again? (yes/no).");
                        string YesNo = Console.ReadLine();
                        string yes = "yes";

                        if (YesNo == yes)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\nNice.");
                            break;
                        }
                        else
                        {
                            GameIsRunning = false;
                            Console.WriteLine("\n\nPress any key to close this window.");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Environment.Exit(0);

                        }

                    }


                    if (word.Contains(NewLetter))
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Good one. ");
                        pvpp(NewLetter, stars, word);
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Wrong.");
                        lifes = lifes - 1;

                        if (lifes == 6)
                        {

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou only have  " + lifes + " lives left.\n");
                            Console.WriteLine("    __________");
                            Console.WriteLine("    |/       |");
                            Console.WriteLine("    |");
                            Console.WriteLine("    |");
                            Console.WriteLine("    |");
                            Console.WriteLine(" _________");
                            Console.WriteLine(" \\_______/");
                        }
                        if (lifes == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou only have " + lifes + " lives left.\n");
                            Console.WriteLine("    __________");
                            Console.WriteLine("    |/       |");
                            Console.WriteLine("    |        o");
                            Console.WriteLine("    |");
                            Console.WriteLine("    |");
                            Console.WriteLine(" _________");
                            Console.WriteLine(" \\_______/");
                        }
                        if (lifes == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou only have " + lifes + " lives left.\n");
                            Console.WriteLine("    __________");
                            Console.WriteLine("    |/       |");
                            Console.WriteLine("    |        o");
                            Console.WriteLine("    |        O");
                            Console.WriteLine("    |");
                            Console.WriteLine(" _________");
                            Console.WriteLine(" \\_______/");
                        }
                        if (lifes == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou only have " + lifes + " lives left.\n");
                            Console.WriteLine("    __________");
                            Console.WriteLine("    |/       |");
                            Console.WriteLine("    |        o");
                            Console.WriteLine("    |       /O");
                            Console.WriteLine("    |");
                            Console.WriteLine(" _________");
                            Console.WriteLine(" \\_______/");
                        }
                        if (lifes == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou only have " + lifes + " lives left.\n");
                            Console.WriteLine("    __________");
                            Console.WriteLine("    |/       |");
                            Console.WriteLine("    |        o");
                            Console.WriteLine("    |       /O\\");
                            Console.WriteLine("    |");
                            Console.WriteLine(" _________");
                            Console.WriteLine(" \\_______/");
                        }
                        if (lifes == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nYou only have " + lifes + " lives left.\n");
                            Console.WriteLine("    __________");
                            Console.WriteLine("    |/       |");
                            Console.WriteLine("    |        o");
                            Console.WriteLine("    |       /O\\");
                            Console.WriteLine("    |       / ");
                            Console.WriteLine(" _________");
                            Console.WriteLine(" \\_______/");
                        }
                        if (lifes == 0)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine();
                            string txt = "You Lost!!!";
                            BlinkinkText(txt, 500);

                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine();
                            Console.WriteLine("    __________");
                            Console.WriteLine("    |/       |");
                            Console.WriteLine("    |        o");
                            Console.WriteLine("    |       /O\\");
                            Console.WriteLine("    |       / \\");
                            Console.WriteLine(" _________");
                            Console.WriteLine(" \\_______/");
                            Console.WriteLine();


                            Console.WriteLine("The guessing word was: " + word);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Do you want to play again? (yes/no).");
                            string YesNo = Console.ReadLine();
                            string yes = "yes";

                            if (YesNo == yes)
                            {
                                Console.Clear();
                                Console.WriteLine("\n\nNice.");
                            }
                            else
                            {
                                GameIsRunning = false;
                                Console.WriteLine("\n\n\nPress any key to close this window.");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Environment.Exit(0);
                            }
                        }
                    }
                }
            } while (GameIsRunning == true);
        }

        static void pvpp(char letter, char[] stars, string word)
        {
            int index = 0;
            char[] WordLetters = word.ToCharArray();
            while (index < stars.Length)
            {
                if (WordLetters[index] == letter)
                {
                    stars[index] = letter;

                }
                index = index + 1;
            }

        }

        static bool NTZH(char[] pole)
        {
            int p = 0;
            while (p < pole.Length)
            {
                if (pole[p] == '*')
                {
                    return false;
                }
                p++;
            }
            return true;
        }
        private static void BlinkinkText(string text, int time)
        {
            bool visible = true;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\r" + (visible ? text : new String(' ', text.Length)));
                System.Threading.Thread.Sleep(time);
                visible = !visible;
            }
        }
    }
}