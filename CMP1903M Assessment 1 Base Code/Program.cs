//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();
            string text;
            //Create 'Input' object
            Input input = new Input();
            //Get either manually entered text, or text from a file
            while (true)
            {
                //Console askes user which method of analyse they wish to use
                Console.WriteLine("Welcome to my text analysis tool, please select an option below");
                Console.WriteLine("1 - Manualy enter text for analysis");
                Console.WriteLine("2 - upload text from a file for analysis");
                Console.WriteLine("Input option here: ");
                string? choice = Console.ReadLine();
                if (choice == "1")
                {
                    text = input.manualTextInput();
                    break;
                }
                else if (choice == "2")
                {
                    text = input.fileTextInput("");
                    break;
                }
                else
                    Console.WriteLine("Invalid input, please try again...");
            }
            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            Analyse analyse = new Analyse();
            parameters = analyse.analyseText(text);

            //Report the results of the analysis
            Report report = new Report();
            report.reportText(parameters);
        }

    }
}