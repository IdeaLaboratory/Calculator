using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{

    public static class ExtensionMethods
    {
        public static void AddTokken(this Token value)
        {
            if (Char.IsDigit(Convert.ToChar(value)))
            {

            }
        }
    }

    public class Expression
    {
        private string inputString;

        public Expression(string inputString)
        {
            this.inputString = inputString;
        }

        private List<Token> Tokenize(string p_inputString)
        {
            List<Token> result = null;

            //ToDo
            string[] inputArray = p_inputString.Split();

            for (int i = 0; i < inputArray.Length; i++)
            {
                char ch = Convert.ToChar(inputArray[i]);
                if (Char.IsNumber(ch))
                {
                    Token lit = new Literal(ch);
                    //Todo: Send it to Evalution
                }
                else if (Char.IsSymbol(ch))
                {
                    switch (ch)
                    {
                        case '+':
                            // do some stuff
                            break;
                        case '-':
                            // do some stuff
                            break;
                        case '*':
                            // do some stuff
                            break;
                        case '/':
                            // do some stuff
                            break;
                        default:
                            throw new Exception();
                            break;
                    }
                }
                else if(ch=='(' || ch==')')
                {
                    //ToDo
                }
            }

            return result;
        }

        private bool Validate()
        {
            bool result = false;
            //Todo

            return result;
        }

        public string Calculate()
        {
            string result = null;
            //ToDo
            List<Token> tokenizedExpression = Tokenize(inputString);

            return result;
        }
    }
}
