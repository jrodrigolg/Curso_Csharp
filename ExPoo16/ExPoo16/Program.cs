using System;

namespace ExPoo16
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            HashSet<int> CourseA = new HashSet<int>();
            HashSet<int> CourseB = new HashSet<int>();
            HashSet<int> CourseC = new HashSet<int>();
            Console.Write("How many students for Course A");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                CourseA.Add(cod);
            }
            Console.Write("How many students for Course B");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                CourseB.Add(cod);
            }
            Console.Write("How many students for Course C");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                CourseC.Add(cod);
            }
            SortedSet<int> all = new SortedSet<int>(CourseA);
            
            all.UnionWith(CourseB);
            all.UnionWith(CourseC);
            Console.WriteLine($"Total Students: { all.Count}");



        }
        
    }
}