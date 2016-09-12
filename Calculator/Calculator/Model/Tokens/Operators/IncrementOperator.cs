using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    [ObsoleteAttribute("Not implemented", true)]
    class IncrementOperator : Operator
    {
        public override Token Evalute(List<Token> args)
        {
            throw new NotImplementedException();
        }
    }
}