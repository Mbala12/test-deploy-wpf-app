using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfMVVMProject.ViewModels;

namespace WpfMVVMProject.Commands
{
    public class AddCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private readonly BaseViewModel _viewModel;
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            // _viewModel.AddPerson();

        }

        public AddCommand(BaseViewModel baseViewModel) 
        { 
            _viewModel = baseViewModel;
        }
    }
}
