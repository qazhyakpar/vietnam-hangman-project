using System;
using System.Collections.Generic;

class HangmanGame
{
    static void Main()
    {
        
        List<string> words = new List<string> { "hangman", "programming", "aibolat", "urmanov", "design", "hello" };

        
        Random random = new Random();
        string secretWord = words[random.Next(words.Count)];

        
        int maxAttempts = 6;
        int attemptsLeft = maxAttempts;

        
        char[] displayWord = new char[secretWord.Length];
        for (int i = 0; i < secretWord.Length; i++)
        {
            displayWord[i] = '_';
        }

        
        while (true)
        {
            
            Console.WriteLine($"Word: {new string(displayWord)}");
            Console.WriteLine($"Attempts left: {attemptsLeft}");

            
            Console.Write("Enter a letter: ");
            char guess = Console.ReadLine().ToLower()[0]; 

            
            bool correctGuess = false;
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == guess)
                {
                    displayWord[i] = guess;
                    correctGuess = true;
                }
            }

            
            if (correctGuess)
            {
                Console.WriteLine("Correct guess!");
            }
            else
            {
                Console.WriteLine("Wrong guess!");
                attemptsLeft--;

                
                DisplayHangman(maxAttempts - attemptsLeft);
            }

            
            if (string.Join("", displayWord) == secretWord)
            {
                Console.WriteLine($"YES! You guessed the word: {secretWord}");
                break;
            }

            if (attemptsLeft == 0)
            {
                Console.WriteLine($"NO, 0 attempts left. The correct word was: {secretWord}");
                break;
            }
        }
    }

    
    static void DisplayHangman(int incorrectAttempts)
    {
        switch (incorrectAttempts)
        {
            case 1:
                Console.WriteLine(" |------  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |    \\ /");
                Console.WriteLine(" |     |");
                Console.WriteLine(" |    /O\\");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |    |||    ");
                Console.WriteLine(" |    ---   ");

                break;
            case 2:
                Console.WriteLine(" |------  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |    \\ /");
                Console.WriteLine(" |     |");
                Console.WriteLine(" |    /O\\");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |    |||    ");
                Console.WriteLine(" |    ---   ");
                break;
            case 3:
                Console.WriteLine(" |------  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |    \\ /");
                Console.WriteLine(" |     |");
                Console.WriteLine(" |    /O\\");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |    |||    ");
                Console.WriteLine(" |    ---   ");
                break;
            case 4:
                Console.WriteLine(" |------  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |    \\ /");
                Console.WriteLine(" |     |");
                Console.WriteLine(" |    /O\\");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |    |||    ");
                Console.WriteLine(" |    ---   ");
                break;
            case 5:
                Console.WriteLine(" |------  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |    \\ /");
                Console.WriteLine(" |     |");
                Console.WriteLine(" |    /O\\");
                Console.WriteLine(" |        ");
                Console.WriteLine(" |    |||    ");
                Console.WriteLine(" |    ---   ");
                break;
            case 6:
                Console.WriteLine(" |------  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |     |  ");
                Console.WriteLine(" |    \\ /");
                Console.WriteLine(" |     |");
                Console.WriteLine(" |    /@\\");
                Console.WriteLine(" |    |||    ");
                Console.WriteLine(" |    ---   ");
                break;
        }
    }
}
