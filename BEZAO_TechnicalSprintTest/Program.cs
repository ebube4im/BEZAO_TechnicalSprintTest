// See https://aka.ms/new-console-template for more information
using BEZAO_TechnicalSprintTest;

Console.WriteLine("BEZAO TECHNICAL TEST");

Console.WriteLine("This Application Constains three simple Programs. Choose which program to Run " +
    "\n Enter 1 to Run Leap Year Printer \n Enter 2 to Run Secret Number Guesser \n Enter 3 to Run Pig Latin Translator");


string selectedresponse = "";

selectedresponse = Console.ReadLine();

if(selectedresponse != "" )
{
    if (selectedresponse == "1")
    {
        Console.WriteLine("Welcome to Leap Year Printer Program");
        LeapYearPrinter leapYear = new LeapYearPrinter();
        leapYear.Print();

    }
    if (selectedresponse == "2")
    {
        Console.WriteLine("Welcome to Secret Answer Guesser Program");

        SecretAnswerGuess secretAnswer = new SecretAnswerGuess();
        int guessCount = 0;
        while (guessCount != 20)
        {
            guessCount++;
            Console.WriteLine("Can you guess our secret number? Enter any number and we will tell you how close you are.");
            secretAnswer.checkNumber(int.Parse(Console.ReadLine()));
            Console.WriteLine(guessCount.ToString());

        }
    }
    if (selectedresponse == "3")
    {
        Console.WriteLine("Welcome to Pig Latin Translator Program");
        PigLatin pigLatin = new PigLatin();

        Console.WriteLine("Enter a sentence to translate");
        pigLatin.wordToTranslate = Console.ReadLine();
        pigLatin.Translate();

        Console.WriteLine("To translate Pig Latin word back to English, Reply Yes");
       
        if (Console.ReadLine().ToUpper() == "YES")
        {
            pigLatin.TranslateBack();
        }
    

    }
}




