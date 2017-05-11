using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billing;

namespace Billing_View
{
    [Serializable]
    class BillingProject
    {
        private List<IEmployee> Employees { get; set; }
    }
}
