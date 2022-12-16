using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleProject.ViewModels
{
    internal class SimpleCommand: ICommand
    {
        readonly Action<object> _execute;
        readonly Func<bool> _canExecute;

        public SimpleCommand(Action<object> execute, Func<bool> canExecute = null)
        {
            this._execute = execute;

            if (canExecute != null)
                this._canExecute = canExecute;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (_canExecute != null)
                return _canExecute();
            return true;
        }

        public void Execute(object parameter = null)
        {
            this._execute(parameter);
        }
    }
}
