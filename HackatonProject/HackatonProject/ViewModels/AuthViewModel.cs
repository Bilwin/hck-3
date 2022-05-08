using HackatonProject.Views;

namespace HackatonProject.ViewModels
{
    public class AuthViewModel
    {
        public NavigationCommand<LogInView> ToLogInViewCommand { get; set; } = new();
        public NavigationCommand<SignInView> ToSignInViewCommand { get; set; } = new();

        public AuthViewModel() { }
    }
}