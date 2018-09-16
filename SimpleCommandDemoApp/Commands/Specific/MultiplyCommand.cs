using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SimpleCommandDemoApp.ViewModels;

namespace SimpleCommandDemoApp.Commands.Specific
{
    public class MultiplyCommand : ICommand
    {
        private CalculatorViewModel calVM;
        public MultiplyCommand(CalculatorViewModel vm)
        {
            calVM = vm;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            calVM.Multiply();
        }
    }
}
