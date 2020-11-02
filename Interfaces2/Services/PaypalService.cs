
namespace Interfaces2.Services
{
    class PaypalService : IPaymentService
    {
        public double Tax(int months, double value)
        {
            return value * 0.01 * months;
        }

        public double Fee(double value)
        {
            return value * 0.02;
        }
    }
}
