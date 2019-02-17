using System;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello! Welcome to the URL Encoding Program.");
                Console.WriteLine("First, let's begin by getting some information. What is the Project Name?");
                string projectName = Console.ReadLine();
                Console.WriteLine("Awesome! Now, what is the Activity Name?");
                string activityName = Console.ReadLine();
                Console.WriteLine("Okay! Here is your URL:");
                Console.WriteLine("https://companyserver.com/content/" + projectName + "/files/" + activityName + "/" + activityName + "Report.pdf");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
