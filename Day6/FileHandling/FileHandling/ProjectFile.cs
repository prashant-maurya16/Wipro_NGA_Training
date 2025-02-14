using System;
using System.IO;

namespace FileHandling
{
    class ProjectFile
    { 

    static void main()
        {
            string logDirectory = "Logs";
            string logFile = Path.Combine(logDirectory, "user_log.txt");

            // Ensure the Logs directory exists
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            // Get user details
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            string age = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Write user details to log file
            using (StreamWriter writer = new StreamWriter(logFile, true))
            {
                writer.WriteLine($"{name}, {age}, {email}, {timestamp}");
            }

            // Read and display all user details
            Console.WriteLine("\nUser Details Log:");
            using (StreamReader reader = new StreamReader(logFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
