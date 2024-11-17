using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PolojitelnoOtricatelnoChislo
{
    public class PositiveNegative
    {
        public bool IsPositive(double num)
        {
            bool result = false;
            if (num < 0)
            {
                result = false;
            }
            if (num > 0)
            {
                result = true;
            }
            if (num == 0)
            {
                throw new ArgumentException("Vuvedenoto chislo e 0!!");
            }
            return result;
        }
    }
}
