using System;
namespace ExPoo17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            try
            {
                Dictionary<string, int> voteRecord = new Dictionary<string, int>();
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);
                        if (voteRecord.ContainsKey(name))
                        {
                            voteRecord[name] += votes;
                        }
                        else
                        {
                            voteRecord[name] = votes;
                        }
                        

                    }
                    foreach (var item in voteRecord)
                    {
                        Console.WriteLine($"{item.Key}, {item.Value}");
                    }
                }


            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }




        }
    }
}