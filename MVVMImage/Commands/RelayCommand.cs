using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMImage.Commands
{
    public class RelayCommand:ICommand
    {


        Action<object> executeMethod;
        Func<object, bool> canExecuteMethod;
        bool canExecuteCache;

        public RelayCommand(Action<object> executeMethod, Func<object, bool> canExecuteMethod, bool canExecuteCache)
        {
            this.executeMethod = executeMethod;
            this.canExecuteMethod = canExecuteMethod;
            this.canExecuteCache = canExecuteCache;
        }


        public bool CanExecute(object parameter)
        {
            if (canExecuteMethod == null)
            {
                return true;

            }
            else
            {
                return canExecuteMethod(parameter);
            }
        }

        public void Execute(object parameter)
        {
            executeMethod(parameter);
        }


        public event EventHandler CanExecuteChanged
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

    }

}

