using System;
using System.Collections.Generic;

namespace Interfaces2.Entities
{
    class Contract
    {

        public int _number { get; set; }
        public DateTime _date { get; set; }
        public double _totalValue { get; set; }
        public List<Installment> _installment { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            _number = number;
            _date = date;
            _totalValue = totalValue;
            _installment = new List<Installment>();
        }


        public List<Installment> Installments(int months)
        {
            double amount = 0.0;
            for (int i = 0; i < months; i++)
            {
                amount = (_totalValue / months) * 1.01 * (i+1) * 1.02;
                _installment.Add(new Installment(_date.AddMonths(i + 1), amount, this));
            }

            return _installment;
        }


    }
}
