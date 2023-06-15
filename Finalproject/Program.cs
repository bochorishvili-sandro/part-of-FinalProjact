using Calculator;
using GuessNumber_and_Hangman;
using Translator_and_GeorgianTranslator;
using ATM;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Console Aplication");
            Console.WriteLine("--------------------");
            Console.WriteLine("1) Calculator");
            Console.WriteLine("2) Guess the Number");
            Console.WriteLine("3) HangMan");
            Console.WriteLine("4) Translator");
            Console.WriteLine("5) Georgian Letter Translator");
            Console.WriteLine("6) ATM");
            Console.WriteLine("7) Exit");

            Console.WriteLine("Choose Number: 1-7");
            int input = Convert.ToInt32(Console.ReadLine());
       
            if (input == 1)
            {
                CalculatorStart.RunCalculator();
            }
            if (input == 2) {
                GuessNumberStart.RunGuessNumber();
            }

            if(input == 7)
            {
                break;
            }


        }
    }
}