using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator.ViewModel
{
    class ClearLastInputCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (!String.IsNullOrEmpty(CalculationManager.Instance.InputString))
            {
                string tempStr = CalculationManager.Instance.InputString;
                tempStr = tempStr.Substring(0, tempStr.Length - 1);
                CalculationManager.Instance.InputString = tempStr;
            }
        }
    }
}
