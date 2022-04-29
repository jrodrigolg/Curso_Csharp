using System;
using ExPoo15.Entities;
namespace ExPoo15
{
    class Program
    {
        static void Main(string[] args)

        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();
            string path = @"c:\Temp\in.txt";
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(" ");
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(name, instant));
                        
                    }
                    Console.WriteLine($"Total Users: {set.Count}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}