using HackatonProject.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class AuthViewModel
    {
        private readonly INavigation _navigation;

        public ICommand ToLogInViewCommand { get; set; }
        public ICommand ToSignInViewCommand { get; set; }

        public AuthViewModel()
        {
            _navigation = DependencyService.Get<INavigation>();

            ToSignInViewCommand = new Command(() =>
            {
                _navigation.PushAsync(new SignInView());
            });

            ToLogInViewCommand = new Command(() =>
            {
                _navigation.PushAsync(new LogInView());
            });
        }
    }
}