using MVVM_Boilerplate.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Boilerplate.Navigation
{
    public class NavigationStore
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                if (value == _currentViewModel)
                    return;
                _currentViewModel = value;
                OnViewModelChanged();
            }
        }

        public event PropertyChangedEventHandler? ViewModelChanged;

        private void OnViewModelChanged()
        {
            ViewModelChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentViewModel)));
        }
    }
}
