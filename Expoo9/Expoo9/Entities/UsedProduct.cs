
using System.Globalization;

namespace Expoo9.Entities
{
    internal class UsedProduct:Product
    {
        DateTime ManufactureDate { get; set; }

        public UsedProduct() : base()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag()+$"(Manufactured date: {ManufactureDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) }";
        }
    }
}
