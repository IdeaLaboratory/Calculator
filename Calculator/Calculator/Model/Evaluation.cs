using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    internal class Evaluation
    {
        #region need to move into SubEqn class

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
        List<SubEquation> subEqns = new List<SubEquation>();

        public Evaluation()
        {
            SubEquation subEqun = new SubEquation();
            subEqns.Add(subEqun);
        }
        #endregion

        public void Push(Token p_token)
        {
            //push in operator/ operand stack
            if (p_token is Operator)
            {
                //operatorStack.
                if (operatorStack.Count == 0 || (operatorStack.Count > 0 && operatorStack.Peek().Priority < (p_token as Operator).Priority))
                {
                    //do remaining operation
                    operatorStack.Push(p_token as Operator);
                }
                else
                {
                    List<Token> args = new List<Token>();
                    for (int i = 0; i < 2; i++) //as these all are binary operators
                    {
                        args.Insert(0, LiteralStack.Pop());
                    }
                    Token tkn = OperatorStack.Pop().Evalute(args);
                    LiteralStack.Push(tkn as Literal);
                    OperatorStack.Push(p_token as Operator);
                }
            }
            else if (p_token is Literal)
            {
                LiteralStack.Push(p_token as Literal);
            }
        }

        internal string Evalute(Token p_operator)
        {
            string result = null;
            //ToDo

            return result;
        }

        internal string Summerize()
        {
            Token tkn = null;

            Operator opt = null;
            List<Token> args = null;
            for (int i = 0; OperatorStack.Count > 0; i++)
            {
                opt = OperatorStack.Pop();
                args = new List<Token>();
                for (int j = 0; j < 2; j++) //as these all are binary operators
                {
                    args.Insert(0, LiteralStack.Pop());
                }
                tkn = opt.Evalute(args);
                LiteralStack.Push(tkn as Literal);
            }
            //opt = OperatorStack.Pop();

            return (tkn as Literal).Value.ToString();
        }
    }
}
