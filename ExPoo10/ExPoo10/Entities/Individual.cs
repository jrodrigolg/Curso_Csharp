using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPoo10.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual() : base()
        {

        }

        public Individual(string name, double anualIncome, double healthExpenditures):base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            double tax;
            if (AnualIncome < 20000)
            {
                tax = 0.15 * AnualIncome;
            }
            else
            {
                tax = 0.25 * AnualIncome;
            }
            if(HealthExpenditures > 0)
            {
                tax -= 0.5 * HealthExpenditures;
            }
            return tax;
        }
    }
}
