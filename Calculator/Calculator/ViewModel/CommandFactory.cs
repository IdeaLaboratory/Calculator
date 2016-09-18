using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator.ViewModel
{
    public static class CommandFactory
    {
        private static ICommand getCalculateCommand;
        public static ICommand GetCalculateCommand
        {
            get
            {
                getCalculateCommand = new CalculateCommand();
                return getCalculateCommand;
            }
        }
        private static ICommand getNumpadCommand;
        public static ICommand GetNumpadCommand
        {
            get
            {
                getNumpadCommand = new NumpadCommand();
                return getNumpadCommand;
            }
        }
        private static ICommand getClearLastInputCommand;
        public static ICommand GetClearLastInputCommand
        {
            get
            {
                getClearLastInputCommand = new ClearLastInputCommand();
                return getClearLastInputCommand;
            }
        }

        private static ICommand getNumberModeCommand;
        public static ICommand GetNumberModeCommand
        {
            get
            {
                getNumberModeCommand = new NumberModeCommand();
                return getNumberModeCommand;
            }
        }
    }
}
