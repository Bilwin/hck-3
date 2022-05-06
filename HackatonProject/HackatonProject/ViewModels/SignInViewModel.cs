using HackatonProject.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class SignInViewModel
    {
        private readonly AppContext _appContext;
        private readonly Page _signInView;

        public ICommand SignInCommand { get; set; }
        public User UserToSignIn { get; set; } = new();

        public SignInViewModel(Page page)
        {
            _signInView = page;
            _appContext = DependencyService.Get<AppContext>();

            SignInCommand = new Command(SignIn);
        }

        private void SignIn(object obj)
        {
            if (string.IsNullOrEmpty(UserToSignIn.Name) || string.IsNullOrEmpty(UserToSignIn.Email) || string.IsNullOrEmpty(UserToSignIn.Phone) || string.IsNullOrEmpty(UserToSignIn.Password))
            {
                _signInView.DisplayAlert("Error", "One of the fields is empty", "Accept");
                return;
            }

            _signInView.DisplayAlert("Success", "Your account created", "Accept");
            _appContext.Add(UserToSignIn);
        }
    }
}