﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPoo13.Entities
{
    internal class Installment
    {
        DateTime Date { get; set; }
        double Amount { get; set; }

        public Installment() { }

        public Installment(DateTime date, double amount)
        {
            Date = date;
            Amount = amount;
        }
    }
}
