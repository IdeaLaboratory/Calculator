using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    public class Parser
    {
        private string inputStr;

        public string Input
        {
            get { return inputStr; }
            set { inputStr = value; }
        }

        private int position;

        public int Position
        {
            get { return position; }
            set { position = value; }
        }


        public Parser()
        {
            position = 0;
        }

        public Parser(string p_input)
        {
            inputStr = p_input;
            position = 0;
        }

        public char Pop(int p_index)
        {
            char result = Input[0];

            return result;
        }
    }
}
