using System;
using System.Globalization;

namespace Expoo9.Entities
{
    internal class ImportedProduct:Product
    {
        double CustomsFee { get; set; }

        public ImportedProduct() : base()
        {

        }

        public ImportedProduct(string name, double price, double customsFee):base(name, price)
        {
            CustomsFee = customsFee;
        }
        public override string PriceTag()
        {
            return base.PriceTag()+$" (Customs fee: $ {CustomsFee.ToString("F2",CultureInfo.InvariantCulture)})";
        }
    }
}
