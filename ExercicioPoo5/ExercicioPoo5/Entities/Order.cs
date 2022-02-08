
using ExercicioPoo5.Entities.Enums;
using System.Globalization;

namespace ExercicioPoo5.Entities {
    class Order {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString() {
            return $"{Id} \n{Moment.ToString(CultureInfo.InvariantCulture)}  \n{Status}";
        }
    }
}
