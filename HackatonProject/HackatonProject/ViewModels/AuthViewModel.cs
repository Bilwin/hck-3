using HackatonProject.Views;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class AuthViewModel
    {
        public NavigationCommand<LogInView> ToLogInViewCommand { get; set; }
        public NavigationCommand<SignInView> ToSignInViewCommand { get; set; }

        public AuthViewModel()
        {
            INavigation navigation = DependencyService.Get<INavigation>();

            ToLogInViewCommand = new(navigation);
            ToSignInViewCommand = new(navigation);
        }
    }
}