using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleCommandDemoApp.Commands.Generic
{
    class RelayCommand : ICommand

    {
        private Action commandTasks;

        public RelayCommand (Action workTodo)
        {
            commandTasks = workTodo;

        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;

        }

        public void Execute(object parameter)
        {
            commandTasks();
        }
    }
}
