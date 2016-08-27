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


    }
}
