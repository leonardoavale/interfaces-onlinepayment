using System;

namespace Interfaces2.Entities
{
    class Installment
    {

        public DateTime _dueDate { get; set; }
        public Contract _contract { get; set; }
        public double _amount { get; set; }


        public Installment(DateTime dueDate, double amount, Contract contract)
        {
            _dueDate = dueDate;
            _contract = contract;
            _amount = amount;
            
        }

        public override string ToString()
        {
            return _dueDate
                + " - "
                + _amount;
        }

    }
}
