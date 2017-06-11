using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Billing;

namespace Billing_View
{
    //TODO: комментарии?
    [Serializable]
    public class BillingProject
    {
        //TODO: комментарии?
        public string Filename { get; set; }

        //TODO: комментарии?
        //TODO: лучше создавать экземпляр списка по умолчанию
        public List<IEmployee> Employees { get; set; }
    }
}
