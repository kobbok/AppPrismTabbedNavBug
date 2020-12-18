using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPrismTabbedNavBug.ViewModels
{
    public class TabBViewModel : ViewModelBase
    {
        public TabBViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Tab B";
        }
    }
}
