using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    class DivisionOperator : Operator
    {
        public DivisionOperator(string p_ch)
        {
            Priority = 4;
        }

        public override Token Evalute(List<Token> args)
        {
            Literal result = null;
            if (args[0] is Literal && args[1] is Literal)
            {
                double d = (args[0] as Literal).Value / (args[1] as Literal).Value;
                result = new Literal(d.ToString());
            }
            return result;
        }
    }
}