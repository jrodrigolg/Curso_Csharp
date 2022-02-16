using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPoo10.Entities
{
    internal class Company: TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company() : base()
        {

        }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double Tax()
        {
            double tax;
            if (NumberOfEmployees < 10)
            {
                tax = 0.16 * AnualIncome;
            }
            else
            {
                tax = 0.14 * AnualIncome;
            }
            return tax;
        }
    }
}
