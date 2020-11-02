using Interfaces2.Entities;
using System;

namespace Interfaces2.Services
{
    class ContractService
    {
        private IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessPayables(Contract contract, int months)
        {
            double Tax, Fee, amount = 0.0;

            for (int i = 0; i < months; i++)
            {
                DateTime date = contract.Date.AddMonths(i + 1);
                Tax = _paymentService.Tax(i + 1, contract.TotalValue / months) + contract.TotalValue / months;
                Fee = _paymentService.Fee(Tax);

                amount = Tax + Fee;
                contract.AddInstallment(new Installment(date, amount));
            }
        }
    }
}
