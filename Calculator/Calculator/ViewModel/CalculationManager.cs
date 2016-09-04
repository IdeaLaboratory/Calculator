using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModel
{
    public class CalculationManager
    {
        #region variables & properties

        private string inputString =  "2 + ( 5 - 3 ) * 8";// null;//

        public string InputString
        {
            get { return inputString; }
            set { inputString = value; }
        }

        private static CalculationManager instance = null;
        public static CalculationManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new CalculationManager();
                return instance;
            }
        }


        #endregion

        #region default constructor
        private CalculationManager()
        {

        }
        #endregion

        #region Command execution
        public void Calculate()
        {
            Model.Expression exp = new Model.Expression(inputString);
            //exp.Tokenize();
            //exp.Validate();
            exp.Calculate();
        }
        #endregion


    }
}
