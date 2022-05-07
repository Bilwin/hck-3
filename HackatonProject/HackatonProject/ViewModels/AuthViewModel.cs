using HackatonProject.Views;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class AuthViewModel
    {
        public NavigationCommand<LogInView> ToLogInViewCommand { get; set; } = new();
        public NavigationCommand<SignInView> ToSignInViewCommand { get; set; } = new();

        public AuthViewModel() { }
    }
}