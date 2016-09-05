using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    public class AditionOperator : Operator
    {
        public AditionOperator(char p_ch)
        {
            base.Priority = 3;
        }
    }
}
