using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEZAO_TechnicalSprintTest
{
    internal class PigLatin
    {
       public string wordToTranslate = "";
        public string translatedWord = "";

        public void Translate()
        {
          string[] newStringArray =  wordToTranslate.Split(' ');

            List<string> newStringArray2 = new List<string>();

            foreach (var item in newStringArray)
            {
                char firstLetter;
                char lastLetter;
                string newWord;

                firstLetter = item.First();
                lastLetter = item.Last();

               newWord = item.Substring(1,item.Length - 1) + firstLetter + "ay";
            
                newStringArray2.Add(newWord);

                
            }

            foreach (var item in newStringArray2)
            {
                translatedWord = translatedWord + item + " ";

            }
            Console.WriteLine(translatedWord);


        }

        public void TranslateBack()
        {
            wordToTranslate = "";
            string[] newStringArray = translatedWord.Split(' ');

            List<string> newStringArray2 = new List<string>();

            foreach (var item in newStringArray)
            {
                
                char lastLetter;
                string newWord;

                string replacedWord = item.Remove(item.Length - 2);

                  
                newWord = replacedWord.Last() + replacedWord.Remove(replacedWord.Length -1);

                newStringArray2.Add(newWord);


            }

            foreach (var item in newStringArray2)
            {
                wordToTranslate = wordToTranslate + item + " "; 

            }
            Console.WriteLine(wordToTranslate);


        }
    }
}
