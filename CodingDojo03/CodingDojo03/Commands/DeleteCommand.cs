using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CodingDojo03.Commands
{
    class DeleteCommand : ICommand
    {
        private Action delete;
        private Func<bool> canDelete;

        public DeleteCommand(Action delete, Func<bool> canDelete)
        {
            this.delete = delete;
            this.canDelete = canDelete;
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
            return canDelete();
        }

        public void Execute(object parameter)
        {
            delete();
        }
    }
}
