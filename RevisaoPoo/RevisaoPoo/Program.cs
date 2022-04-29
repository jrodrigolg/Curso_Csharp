using System;
namespace RevisaoPoo
{
    class Program
    {
        static void Main (string[] args)
        {
            SortedSet<int> a = new() { 0, 2, 3, 4, 6, 8, 10 };
            SortedSet<int> b = new() { 9, 8, 7, 6, 1, 5};
            
            //union
            HashSet<int> c = new(a);
            c.UnionWith(b);
            PrintCollection(c);
            //intersection
            SortedSet<int> d = new(a);
            d.IntersectWith(b);
            PrintCollection(d);
            //difference
            SortedSet<int> e = new(a);
            e.ExceptWith(b);
            PrintCollection(e);

        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}