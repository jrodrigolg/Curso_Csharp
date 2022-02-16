
namespace ExPoo8.Entities
{
    internal class OutSourcedEmployee : Employee
    {
        double AdditionalCharge { get; set; }
        public OutSourcedEmployee() : base()
        {
        }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (1.1 * AdditionalCharge);

        }
    }
}
