using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDInPractice.UI.Common
{
    public class MainViewModel:ViewModel
    {
        public MainViewModel()
        {
            var viewModel = new SnackMachineViewModel(new Logic.SnackMachine());
            _dialogService.ShowDialog (viewModel);

        }
    }
}
