﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppPrismTabbedNavBug.ViewModels
{
    public class MainTabbedPageViewModel : ViewModelBase
    {
        public MainTabbedPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
    }
}
