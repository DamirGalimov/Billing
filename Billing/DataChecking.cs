using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing
{
    public class DataChecking
    {
        public static string SetChecking(string val)
        {
            val = val.Trim();
            for (int i = 0; i < val.Length; i++)
            {
                if (!Char.IsLetter(val[i]))
                {
                    throw new ArgumentException("Имя содержит не буквенные символы");
                }
            }

            return (val.Substring(0, 1).ToUpper() + val.Remove(0, 1));
        }
    }
}