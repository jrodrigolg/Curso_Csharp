using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExPoo11.Entities.Exceptions;

namespace ExPoo11.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation() { }
        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;

        }
        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            else if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            Checkin = checkin;
            Checkout = checkout;
        }
        public override string ToString() =>
            $"Room: {RoomNumber}, " +
            $"checki-in: {Checkin:dd/MM/yyyy}, " +
            $"checki-out: {Checkout:dd/MM/yyyy}" +
            $", {Duration()} nights";
        
    }
}
