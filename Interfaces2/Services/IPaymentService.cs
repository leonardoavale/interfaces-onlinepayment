
namespace Interfaces2.Services
{
    interface IPaymentService
    {
        double Tax(int months, double value);
        double Fee(double value);
    }
}
