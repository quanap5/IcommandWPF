using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SimpleCommandDemoApp.ViewModels;

namespace SimpleCommandDemoApp.Commands.Specific
{
    public class PlusCommand : ICommand
    {
        private CalculatorViewModel calViewModel;

     

        public PlusCommand(CalculatorViewModel vm)
        {
            calViewModel = vm;

        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            calViewModel.Add();
        }
    }
}
