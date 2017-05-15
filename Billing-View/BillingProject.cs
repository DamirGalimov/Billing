using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Billing;

namespace Billing_View
{
    [Serializable]
    public class BillingProject
    {
        public string Filename { get; set; }
        public List<IEmployee> Employees { get; set; }
    }
}
