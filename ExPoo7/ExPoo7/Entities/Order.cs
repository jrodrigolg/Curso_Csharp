using System.Text;
using System.Globalization;
using ExPoo7.Entities.Enums;
namespace ExPoo7.Entities {
    internal class Order {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        List<OrderItem> Items = new List<OrderItem>();
        public Order() { }

        public Order(OrderStatus status, Client client) {
            Date = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Items.Remove(item);
        }

        public double Total() {
            double total = 0;
            foreach (OrderItem item in Items) {
                total += item.SubTotal();
            }
            return total;
        }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Date.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine($"{Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}) - {Client.Email}");
            sb.AppendLine("Order Items: ");
            foreach (OrderItem item in Items) {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Total Price: ${Total():F2}");

            return sb.ToString();


        }


    }
}
