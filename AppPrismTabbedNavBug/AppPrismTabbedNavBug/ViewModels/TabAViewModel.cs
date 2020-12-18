using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppPrismTabbedNavBug.ViewModels
{
    public class TabAViewModel : ViewModelBase
    {
        public TabAViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Tab A";
        }
    }
}
