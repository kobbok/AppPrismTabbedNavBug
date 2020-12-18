using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppPrismTabbedNavBug.ViewModels
{
    public class TabASubpage2ViewModel : ViewModelBase
    {
        public TabASubpage2ViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Subpage 2";
        }
    }
}
