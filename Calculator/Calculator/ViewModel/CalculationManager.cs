using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModel
{
    public class CalculationManager : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #region variables & properties

        private string inputString = null;// null;//

        public string InputString
        {
            get { return inputString; }
            set
            {
                inputString = value;
                OnPropertyChanged("InputString");
            }
        }

        private string _outputString;

        public string OutputString
        {
            get { return _outputString; }
            set
            {
                _outputString = value;
                OnPropertyChanged("OutputString");
            }
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
            string result = exp.Calculate();
            OutputString = result;
        }
        #endregion


    }
}
