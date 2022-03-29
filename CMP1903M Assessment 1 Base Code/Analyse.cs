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
            //1. Number of sentences
            char[] sentenceEnd = { '.', ':' };
            string[] sentences = input.Split(sentenceEnd);
            int sentenceCount = 0;
            foreach (string s in sentences)
            {
                if (s != "." && s != ":" && s != "")
                    sentenceCount++;
            }
            //2. Number of vowels
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            var vowelCount = input.ToLower().Count(vowels.Contains);
            //3. Number of consonants
            char[] consonants = "bcdfghjklmnpqrstvwxyz".ToCharArray();
            var consonantCount = input.ToLower().Count(consonants.Contains);
            //4. Number of upper case letters
            char[] uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var uppercaseCount = input.Count(uppercase.Contains);
            //5. Number of lower case letters
            char[] lowercase = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var lowercaseCount = input.Count(lowercase.Contains);
            List<int> values = new List<int>();

            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
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
