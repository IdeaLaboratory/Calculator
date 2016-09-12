using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    public class SubEquation
    {
        private Stack<Operator> operatorStack = new Stack<Operator>();

        public Stack<Operator> OperatorStack
        {
            get { return operatorStack; }
            set { operatorStack = value; }
        }

        private Stack<Literal> literalStack = new Stack<Literal>();

        public Stack<Literal> LiteralStack
        {
            get { return literalStack; }
            set { literalStack = value; }
        }
    }
}
