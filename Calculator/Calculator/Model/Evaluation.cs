using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    internal class Evaluation
    {
        private Stack<Operator> operatorStack= new Stack<Operator>();

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

        void Push(Token p_token)
        {
            //push in operator/ operand stack
            if (p_token is Operator)
            {
                //operatorStack.
            }
        }

        internal string Evalute(Token p_operator)
        {
            string result = null;
            //ToDo

            return result;
        }
    }
}
