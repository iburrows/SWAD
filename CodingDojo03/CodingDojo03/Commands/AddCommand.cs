using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CodingDojo03.Commands
{
    class AddCommand : ICommand
    {
        private Action add;
        private Func<bool> canAdd;

        public AddCommand(Action add, Func<bool> canAdd)
        {
            this.add = add;
            this.canAdd = canAdd;
        }

        event EventHandler ICommand.CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return canAdd();
        }

        public void Execute(object parameter)
        {
            add();
        }
    }
}
