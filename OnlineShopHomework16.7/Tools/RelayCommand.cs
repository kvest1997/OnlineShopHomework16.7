using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace OnlineShopHomework16._7.Tools
{
    public class RelayCommand : ICommand
    {
        private readonly Func<object, bool> canExecute;
        private readonly Action<object> execute;

        public RelayCommand(Action<object> executeAction)
            :this(executeAction, null)
        {

        }

        public RelayCommand(Action<object> executeAction, Func<object, bool> canExecuteFunction)
        {
            execute = executeAction;
            canExecute = canExecuteFunction;
        }

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }

        public virtual bool CanExecute(object parameter)
        {
            if (canExecute == null)
            {
                return true;
            }

            return canExecute(parameter);
        }

        public virtual void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
