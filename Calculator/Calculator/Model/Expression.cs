using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
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
            //ToDo by Subha

            return result;
        }

        private bool Validate()
        {
            bool result = false;
            //Todo subha
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
