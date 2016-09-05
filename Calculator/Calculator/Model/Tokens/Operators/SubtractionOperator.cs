using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    public class SubtractionOperator : Operator
    {
        public SubtractionOperator(char p_ch)
        {
            Priority = 3;
        }
    }
}
