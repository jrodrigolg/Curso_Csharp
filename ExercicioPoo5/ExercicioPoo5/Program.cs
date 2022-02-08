using System;

using ExercicioPoo5.Entities;
using ExercicioPoo5.Entities.Enums;
namespace ExercicioPoo5 {
    class Program {
        static void Main(string[] args) {
            Order order = new Order() {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            string ordertxt = order.ToString();
            Console.WriteLine(ordertxt);

        }
    }
}