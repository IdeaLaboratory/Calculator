using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    /// <summary>
    /// Base class for all types of operators containing basic features
    /// </summary>
    public class Operator : Token
    {
        private int _priority;

        /// <summary>
        /// Priority of the operator, 1 is highest
        /// </summary>
        public int Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }
    }
}