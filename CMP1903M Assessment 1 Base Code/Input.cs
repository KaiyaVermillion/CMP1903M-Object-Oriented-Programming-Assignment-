using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "";

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            while (true)
            {
                Console.WriteLine("Please enter your text for analysis");
                text = text + Console.ReadLine();
                while (true)
                {
                    Console.WriteLine("1 - To add more text");
                    Console.WriteLine("2 - To begin analysis");
                    string choice = Console.ReadLine();
                    if (choice == "1")
                        break;
                    else if (choice == "2")
                        return text;
                    else
                        Console.WriteLine("Invalid input, please try again...");
                }
            }

            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            while (true)
            {
                Console.WriteLine("Please enter the full file path of the text file you wish to analyse");
                string path = Console.ReadLine();
                try
                {
                    string text = File.ReadAllText(path);
                    return text;
                }

                catch (Exception)
                {
                    Console.WriteLine("Invalid input, please try again...");
                }
            }
            return text;
        }

    }
}
