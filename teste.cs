using system;
namespace course{
    class Program{
        static void Main(string[] args){
            double x, y, average;

            Console.Write("Enter the first number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            y = int.Parse(Console.ReadLine());
            average = (x + y) / 2.0;
            Console.writeline("Average = "+average);
        }
    }

}