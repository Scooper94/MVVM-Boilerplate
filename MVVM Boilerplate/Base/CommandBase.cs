using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Boilerplate.Base
{
    public abstract class CommandBase : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        //By Default, the base command can always be executed.
        public virtual bool CanExecute(object? parameter)
        {
            return true;
        }

        //Implementations must define their own Execute method
        public abstract void Execute(object? parameter);

        protected void OnCanExecuteChanged(object? parameter)
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }

    }
}
