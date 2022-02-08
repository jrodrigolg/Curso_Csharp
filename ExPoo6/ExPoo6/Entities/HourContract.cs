using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPoo6.Entities {
    internal class HourContract {
        public DateTime Date { get; set; }
        public Double ValuePerHour { get; set; }
        int Hours { get; set; }

        public HourContract(){
        }
        public HourContract(DateTime date, Double valuePerHour, int hours) {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        public double TotalValue() {
            return Hours * ValuePerHour;
        }
    }
}
