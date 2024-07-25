using System.Windows.Input;

namespace ControlsDemo
{
    internal class RefreshCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        => true;

        public void Execute(object parameter)
        {
            //To do: implement the data feeding logic
            //throw new NotImplementedException();
        }
    }
}
