using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        public void reportText(List<int> numbers)
        {
            Console.WriteLine("Your text contains: ");
            Console.WriteLine(numbers.ElementAt(0) + " sentences");
            Console.WriteLine(numbers.ElementAt(1) + " vowels");
            Console.WriteLine(numbers.ElementAt(2) + " consonants");
            Console.WriteLine(numbers.ElementAt(3) + " characters in the uppercase");
            Console.WriteLine(numbers.ElementAt(4) + " characters in the lowercase");
        }
    }
}