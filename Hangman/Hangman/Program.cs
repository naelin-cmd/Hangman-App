using System;
namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what word would you like to use?");
            string wordPuzzle = Console.ReadLine();
            char[] wPLetters = new char[wordPuzzle.Length];
            for (int i = 0; i < wordPuzzle.Length; i++)
            {
                if (wordPuzzle[i].ToString() == " ")
                {
                    wPLetters[i] = ' ';
                }
                else
                    wPLetters[i] = '*';
            }
            Console.WriteLine(wPLetters);
            Console.WriteLine("let the guessing begin!!");
            int attempts = wordPuzzle.Length + 3;
            Console.WriteLine($"Attempts : {attempts} ");
            for (int g = 0; g < attempts; g++)
            {
                string win = string.Join("", wPLetters);
                if (wordPuzzle == win)
                {
                    Console.WriteLine("YOU WIN!");
                    attempts = 0;
                }
                char guessLetter = Console.ReadKey().KeyChar;
                for (int a = 0; a < wordPuzzle.Length; a++)
                {
                    if (guessLetter == wordPuzzle[a])
                    {
                        if (guessLetter == wPLetters[a])
                        {
                            Console.WriteLine("");
                            Console.WriteLine($": Already guessed --> '{guessLetter}' ");
                            Console.WriteLine($"You have --> {attempts - g + 1} attempts left ");
                        }
                        wPLetters[a] = guessLetter;
                        Console.WriteLine(" ");
                        Console.WriteLine(wPLetters);
                    }
                }
            }
            string lose = string.Join("", wPLetters);
            if (wordPuzzle != lose)
            {
                Console.WriteLine(" ");
                Console.WriteLine("YOU LOSE!");
                attempts = 0;
            }
        }
    }
}

