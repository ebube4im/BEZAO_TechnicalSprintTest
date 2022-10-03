using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEZAO_TechnicalSprintTest
{
    internal class SecretAnswerGuess
    {
        int SecretNumber = 25;

        public void checkNumber(int number)
        {

            if (number > SecretNumber)
            {
                Console.WriteLine("Your guess " + number + " is too large");
            }
            else if (number < SecretNumber)
                Console.WriteLine("Your guess " + number + " is too small");
            else if (number == SecretNumber){
                Console.WriteLine("Your guess " + number + " is Correct");
            }
            
        }
    }
}
