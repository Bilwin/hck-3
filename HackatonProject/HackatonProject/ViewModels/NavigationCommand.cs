﻿using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class NavigationCommand<Page> : ICommand where Page : Xamarin.Forms.Page, new()
    {
        private Page _page;
        private readonly INavigation _navigation;

        public event EventHandler CanExecuteChanged;

        public NavigationCommand()
        {
            _navigation = DependencyService.Get<INavigation>();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _page = new();

            _navigation.PushAsync(_page);
        }
    }
}