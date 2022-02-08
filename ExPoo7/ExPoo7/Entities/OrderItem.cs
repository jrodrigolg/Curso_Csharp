

namespace ExPoo7.Entities {
    internal class OrderItem {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product;

        public OrderItem() { }

        public OrderItem(int quantity, Product product) {
            Quantity = quantity;
            Price = product.Price;
            Product = product;
        }

        public double SubTotal() {
            return Quantity * Price;
        }
        public override string ToString() {
            return $"{Product.Name}, ${Price:F2}, Quantity: {Quantity}, Subtotal {SubTotal()}";
        }
    }
}
