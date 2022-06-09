using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.Core.Command
{
    public sealed class RelayCommandAsync : ICommand
    {
        private readonly Func<Task> _execute;
        private readonly Predicate<object> _canExecute;
        private readonly Action<Exception> _onException;
        private bool _is_executing;
        public bool IsExecuting
        {
            get {return _is_executing;}
            set
            {
                _is_executing = value;
                //CanExecuteChanged-=
                //CanExecuteChanged?.Invoke(this, new EventArgs());
            }
        }

        public RelayCommandAsync(Func<Task> execute, Predicate<object> canExecute, Action<Exception> onException)
        {
            _onException=onException;
            _canExecute= canExecute ?? ((object p)=>!IsExecuting);
            _execute=execute;
        }
		
        public async void Execute(object parameter)
        {
            IsExecuting = true;
            Task tsk;
            tsk=ExecuteAsync(parameter);
            /*try
            {
                tsk=ExecuteAsync(parameter);
                tsk.Wait();
            }
            catch (Exception ex)
            {
                _onException?.Invoke(ex);
            }*/
            tsk.ContinueWith(task  =>
            {
                IsExecuting=false;
            });

        }
        private async Task ExecuteAsync(object parameter)
        {
            await _execute();
        }
        public bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke(parameter) ?? true;
        }
		
        public event EventHandler CanExecuteChanged
        {
            add {CommandManager.RequerySuggested+=value;}
            remove {CommandManager.RequerySuggested-=value;}
        }
    }
    
    public sealed class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        public RelayCommand(
            Action<object> execute,
            Predicate<object> canExecute = null)
        {
            _canExecute = canExecute;
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        }
        
        public bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke(parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add =>
                CommandManager.RequerySuggested += value;

            remove =>
                CommandManager.RequerySuggested -= value;
        }
    }
}
