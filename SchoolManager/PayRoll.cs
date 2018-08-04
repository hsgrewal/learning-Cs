using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManager
{
    interface IPayee
    {
        void Pay();
    }

    class PayRoll
    {
        List<IPayee> payees = new List<IPayee>();

        public PayRoll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());

            Logger.Log("Payroll started", 1, "Payroll");
        }

        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }

            Logger.Log("PayAll completed", 2, "Payroll");
        }
    }
}