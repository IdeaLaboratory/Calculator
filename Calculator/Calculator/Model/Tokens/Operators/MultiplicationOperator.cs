using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    class MultiplicationOperator : Operator
    {
        public MultiplicationOperator(string p_ch)
        {
            base.Priority = 4;
        }

        public override Token Evalute(List<Token> args)
        {
            double result = (args[0] as Literal).Value * (args[1] as Literal).Value;
            return new Literal(result.ToString());
        }
    }
}