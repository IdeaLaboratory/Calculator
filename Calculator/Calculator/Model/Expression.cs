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
            List<Token> result = new List<Token>();

            //ToDo
            string[] inputArray = p_inputString.Split();

            for (int i = 0; i < inputArray.Length; i++)
            {
                //Token
                Token tkn = null;
                char ch = Convert.ToChar(inputArray[i]);
                if (Char.IsNumber(ch))
                {
                    tkn = new Literal(ch);
                    result.Add(tkn);
                    //Todo: Send it to Evalution
                }


                else if (ch == '(' || ch == ')')
                {
                    //ToDo
                }
                else
                {
                    switch (ch)
                    {
                        case '+':
                            // do some stuff
                            tkn = new AditionOperator(ch);
                            result.Add(tkn);
                            break;
                        case '-':
                            // do some stuff
                            tkn = new SubtractionOperator(ch);
                            result.Add(tkn);
                            break;
                        case '*':
                            // do some stuff
                            tkn = new MultiplicationOperator(ch);
                            result.Add(tkn);
                            break;
                        case '/':
                            // do some stuff
                            tkn = new DivisionOperator(ch);
                            result.Add(tkn);
                            break;
                        default:
                            throw new Exception("invalid symbol");
                            break;

                    }
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
