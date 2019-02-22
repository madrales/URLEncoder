using System;
using System.Collections.Generic;

namespace URLEncoder
{
    class Program
    {
        static string urlFormatString = "https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf";
       

        static void Main(string[] args)
        {
            Console.WriteLine("URL Encoder");

            do
            {
                Console.Write("\nProject name: ");
                string projectName = GetUserInput();
                Console.Write("Activity name: ");
                string activityName = GetUserInput();

                Console.WriteLine(CreateURL(projectName, activityName));

                Console.Write("Would you like to do another? (y/n): ");
            } while (Console.ReadLine().ToLower().Equals("y"));
        }

        static string CreateURL(string projectName, string activityName)
        {
            Console.WriteLine("https://companyserver.com/content/" + projectName + "/files/" + activityName + "/" + activityName + "Report.pdf");
        }

        static string GetUserInput()
        {
            string input = "";
            do
            {
                input = Console.ReadLine();
                if (IsValid(input)) return input;
                Console.WriteLine("The input contains invaldi characters. Enter again: ");
            } while (true);
        }

        static bool IsValid(string input)
        {
            foreach (char character in input.ToCharArray())
            {
                if (character == 0x1F)
                {
                    Console.WriteLine("Sorry! Hexadecimal numbers are not allowed. Try Again.");
                }

            }
        }

        static string Encode(string value)
        {
            string encodedValue = "";
            foreach (char character in value.ToCharArray())
            {

            }
        }
    }
}