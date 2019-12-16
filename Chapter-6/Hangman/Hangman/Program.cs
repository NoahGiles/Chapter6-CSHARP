using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            bool wrong = true;
            bool win = false;
            int i = 0;
            string[] words = {"mouse", "cat", "box", "dinosaur", "arachnophobia",
                "tarantula", "lizard", "pleasehelpme", "insecticide", "thing", "help"};
            char[] userChoice = {' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '
            , ' ', ' ',' ', ' ', ' ', ' '};
            Random random = new Random();
            int wordChoice = random.Next(1, words.Length);
            var matchingWord = new StringBuilder();
            
            
            while (wrong)
            {
                Console.WriteLine("Let's play hangman!!!");
                Console.WriteLine(words[wordChoice]);
                //Asks for responses for five times more than the chosen word
                for (int j = 0; j < words[wordChoice].Length + 5 && wrong; j++)
                {
                    Console.Write("Guesses : ");
                    for (int k = 0; k < userChoice.Length; ++k)
                    {
                        Console.Write(userChoice[k] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Take a guess!");
                    
                    userChoice[i] = char.ToLower((Convert.ToChar(Console.ReadLine())));
                    if (words[wordChoice].Contains(userChoice[i]) == true)
                    {
                        Console.WriteLine("Yes, continue.");
                        matchingWord.Append(userChoice[i]); 
                    }
                    else
                    {
                        Console.WriteLine("No, {0} is not in the word.", userChoice[i]);
                    }
                    i++;
                    }
                if (Convert.ToString(matchingWord) == words[wordChoice])
                {
                    wrong = false;
                    win = true;
                }
                else
                {
                    wrong = false;
                }
            }
            if (win == true)
            {
                Console.WriteLine("You win! The word was {0}!", matchingWord);
            }
            else
                Console.WriteLine("You lose!");
            
        }
    }
}
