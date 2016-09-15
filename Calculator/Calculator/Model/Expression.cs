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
            Parser parserObj = new Parser(p_inputString);
            List<string> inputArray = parserObj.Tokenize();// p_inputString.Split();

            for (int i = 0; i < inputArray.Count; i++)
            {
                //Token
                Token tkn = null;
                string ch = Convert.ToString(inputArray[i]);
                double tempD;
                if (double.TryParse(ch, out tempD))
                {
                    tkn = new Literal(tempD.ToString());
                    result.Add(tkn);
                    //Todo: Send it to Evalution
                }
                else if (ch == "(" || ch == ")")
                {
                    //ToDo

                }
                else
                {
                    switch (ch)
                    {
                        case "+":
                            // do some stuff
                            tkn = new AditionOperator(ch);
                            result.Add(tkn);
                            break;
                        case "-":
                            // do some stuff
                            tkn = new SubtractionOperator(ch);
                            result.Add(tkn);
                            break;
                        case "*":
                            // do some stuff
                            tkn = new MultiplicationOperator(ch);
                            result.Add(tkn);
                            break;
                        case "/":
                            // do some stuff
                            tkn = new DivisionOperator(ch);
                            result.Add(tkn);
                            break;
                        default:
                            throw new Exception("invalid symbol");
                            //break;
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
            Evaluation eval = new Evaluation();
            List<Token> tokenizedExpression = Tokenize(inputString);

            foreach (Token tkn in tokenizedExpression)
            {
                eval.Push(tkn);
            }

            //
            result = eval.Summerize();

            return result;
        }
    }
}
