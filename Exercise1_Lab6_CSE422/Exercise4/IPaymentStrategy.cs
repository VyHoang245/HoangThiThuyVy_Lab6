using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
     interface IPaymentStrategy
    {
        void ProcessPayment(double amount);
    }
}
