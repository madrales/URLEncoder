using System;

namespace URLEncoder
{
    class Program
    {
        static bool flag = false;
        public static string[] controls = { "?", "/", "@", "&", ";", ":", "$", "+", "=" };
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.WriteLine("Hello! Welcome to the URL Encoding Program.");
                    Console.WriteLine("First, let's begin by getting some information. What is the Project Name?");
                    string projectName = GetUserInput();
                    Console.WriteLine("Awesome! Now, what is the Activity Name?");
                    string activityName = GetUserInput();
                    Console.WriteLine("Okay! Here is your URL:");
                    Console.WriteLine("https://companyserver.com/content/" + projectName + "/files/" + activityName + "/" + activityName + "Report.pdf");
                }
                catch
                {
                    Console.WriteLine("Please enter valid details.");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Would you like to create another URL?");
                Console.WriteLine("Y/N");
                char response = Convert.ToChar(Console.ReadLine());
                if (response == 'y')
                {
                    flag = true;
                }
                if (response == 'n')
                {
                    flag = false;
                }
            } while (flag == true);
        }
        static string GetUserInput()
        {
            string input = "";
            do
            {
                input = Console.ReadLine();
                if (IsValid(input)) return input;
                Console.Write("This input doesn't work.");
            } while (true);
        }
        static bool IsValid(string input)
        {
            foreach (char character in input.ToCharArray())
            {
                if (input.ToLower().Contains("?"))
                {
                    Console.WriteLine("Invalid input.");
                    return false;
                }
                if (input.ToLower().Contains("/"))
                {
                    Console.WriteLine("Invalid input.");
                    return false;
                }
                if (input.ToLower().Contains("$"))
                {
                    Console.WriteLine("Invalid input.");
                    return false;
                }
                if (input.ToLower().Contains("="))
                {
                    Console.WriteLine("Invalid input.");
                    return false;
                }
                if (input.ToLower().Contains("+"))
                {
                    Console.WriteLine("Invalid input.");
                    return false;
                }
                if (input.ToLower().Contains("&"))
                {
                    Console.WriteLine("Invalid input.");
                    return false;
                }
                if (input.ToLower().Contains("@"))
                {
                    Console.WriteLine("Invalid input.");
                    return false;
                }
                if (input.ToLower().Contains(":"))
                {
                    Console.WriteLine("Invalid input.");
                    return false;
                }
                if (input.ToLower().Contains(";"))
                {
                    Console.WriteLine("Invalid input.");
                    return false;
                }
                if (character == 0x1F)
                {
                    Console.WriteLine("Hexadecimals can not be accepted. Sorry!");
                    return false;
                }
                else
                {
                    Console.WriteLine("Input given deemed valid.");
                    return true;
                }
            }
            return true;
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
// "/", "@", "&", ";", ":", "$", "+", "="