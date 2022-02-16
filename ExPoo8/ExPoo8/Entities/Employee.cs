
using System.Collections.Generic;

using System.Text;


namespace ExPoo8.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee() { }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours*ValuePerHour;
        }
        public override string ToString()
        {
            return $"{Name} - $ {Payment():F2}";
        }

    }
}
