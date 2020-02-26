
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMImage.Commands
{
 


        public class ParameterLessCommand : ICommand

        {


            private Action _execute;

            public ParameterLessCommand(Action execute)
            {

                _execute = execute;

            }


            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
            _execute.Invoke();
        }

    }

    }

