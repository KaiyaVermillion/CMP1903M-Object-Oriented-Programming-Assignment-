using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //Number of sentences
            char[] sentenceEnd = { '.', '!', '?' };
            string[] sentences = input.Split(sentenceEnd); //Splits text at every instance of a . ! or ?
            int sentenceCount = 0;
            foreach (string s in sentences)
            {
                if (s != "." && s != "!" && s != "?" && s != "") //Program kept counting a blank space at the end of text as a sentence
                    sentenceCount++;
            }
            //Number of vowels
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            var vowelCount = input.ToLower().Count(vowels.Contains);
            //Number of consonants
            char[] consonants = "bcdfghjklmnpqrstvwxyz".ToCharArray();
            var consonantCount = input.ToLower().Count(consonants.Contains);
            //Number of upper case letters
            char[] uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var uppercaseCount = input.Count(uppercase.Contains);
            //Number of lower case letters
            char[] lowercase = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var lowercaseCount = input.Count(lowercase.Contains);
            List<int> values = new List<int>();

            //Initialise all the values in the list to '0'
            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }

            values[0] = sentenceCount;
            values[1] = vowelCount;
            values[2] = consonantCount;
            values[3] = uppercaseCount;
            values[4] = lowercaseCount;


            return values;
        }
    }
}
