using HackatonProject.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class WelcomeViewModel
    {
        private readonly INavigation _navigation;
        public ICommand ToAuthViewCommand { get; set; }

        public WelcomeViewModel()
        {
            _navigation = DependencyService.Get<INavigation>();

            ToAuthViewCommand = new Command(() =>
            {
                _navigation.PushAsync(new AuthView());
            });
        }
    }
}