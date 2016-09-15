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
            char result = Input[p_index];

            return result;
        }

        public List<string> Tokenize()
        {
            List<string> result = new List<string>();
            bool isdigit = false;

            string ch = null;
            for (int i = Position; Position < Input.Length-1; i++)
            {

                if (char.IsDigit(Input[Position]))
                {
                    isdigit = true;
                    ch = null;
                    ch += Input[Position];
                    while (isdigit && MaxPosition(Position) && char.IsDigit(Input[++Position]))
                    {
                        ch += Input[Position];
                    }
                }
                else
                {
                    ch = null;
                    isdigit = false;
                    ch += Input[Position++];
                }

                result.Add(ch);

                //break;
            }
            return result;
        }

        private bool MaxPosition(int poistion)
        {
            return poistion < Input.Length - 1;
        }
    }
}
