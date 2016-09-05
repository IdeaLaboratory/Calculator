using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    /// <summary>
    /// Literal is nothing but the constant values.
    /// ToDO:
    /// </summary>
    public class Literal : Token
    {
        //private string data;

        //public string Data
        //{
        //    get { return data; }
        //    set { data = value; }
        //}

        private double _value;

        public double Value
        {
            get { return _value; }
            set { value = _value; }
        }

        public Literal(char ch)
        {
            try
            {
                Double.TryParse(ch.ToString(), out _value);
            }
            catch (Exception e)
            {
                throw new Exception("invalid character:" + ch);
            }
        }
    }
}
