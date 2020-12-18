using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppPrismTabbedNavBug.ViewModels
{
    public class TabASubpage1ViewModel : ViewModelBase
    {
        public TabASubpage1ViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Subpage 1";
        }
    }
}
