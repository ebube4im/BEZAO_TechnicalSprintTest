// See https://aka.ms/new-console-template for more information
using BEZAO_TechnicalSprintTest;

Console.WriteLine("BEZAO TECHNICAL TEST");


//LeapYearPrinter leapYear = new LeapYearPrinter();
//leapYear.Print();

SecretAnswerGuess secretAnswer = new SecretAnswerGuess();
int guessCount = 0;
while (guessCount != 20)
{
    guessCount++;
    Console.WriteLine("Can you guess our secret number? Enter any number and we will tell you how close you are.");
    secretAnswer.checkNumber(int.Parse(Console.ReadLine()));
    Console.WriteLine(guessCount.ToString());

}
 

