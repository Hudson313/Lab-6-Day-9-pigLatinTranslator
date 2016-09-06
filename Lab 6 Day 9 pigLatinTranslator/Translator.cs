using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Day_9_pigLatinTranslator
{
    public class Translator
    {
        public string Translate(string wordToTranslate)

        {


            if (IsFirstLetterVowel(wordToTranslate))
            {
                return wordToTranslate + "way";
            }

            else
              { int indexofFirstVowel = 0;

                while (!IsFirstLetterVowel(wordToTranslate.Substring(indexofFirstVowel, 1)))

                {
                    indexofFirstVowel++;

                }
                string translatedString = (wordToTranslate.Substring(indexofFirstVowel) + wordToTranslate.Substring(0, indexofFirstVowel) + "ay");
                return translatedString;
            
            }       
                    

        }

        bool IsFirstLetterVowel(string wordToTranslate)
        {

            bool wordThatStartsWithVowel = wordToTranslate.StartsWith("a") || wordToTranslate.StartsWith("e") || wordToTranslate.StartsWith("i") || wordToTranslate.StartsWith("o") || wordToTranslate.StartsWith("u");
            return wordThatStartsWithVowel;
        }





    }
}

