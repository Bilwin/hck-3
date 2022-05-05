using HackatonProject.Models;
using HackatonProject.Views;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class LogInViewModel
    {
        private readonly AppContext _appContext;
        private readonly Page _signInView;
        private readonly INavigation _navigation;

        public ICommand LogInCommand { get; set; }
        public ICommand ProfileCommand { get; set; }
        public User UserToLogIn { get; set; } = new();
        public User LoggedUser { get; set; }

        public LogInViewModel(Page page)
        {
            _signInView = page;
            LoggedUser = DependencyService.Get<User>();
            _appContext = DependencyService.Get<AppContext>();
            _navigation = DependencyService.Get<INavigation>();

            ProfileCommand = new Command(() =>
            {
                _navigation.PushAsync(new ProfileView());
            });

            LogInCommand = new Command(LogIn);
        }

        private void LogIn(object obj)
        {
            if (string.IsNullOrEmpty(UserToLogIn.Email) || string.IsNullOrEmpty(UserToLogIn.Password))
            {
                _signInView.DisplayAlert("Error", "One of the fields is empty", "Accept");
                return;
            }

            var user = _appContext.Users.ToList().Where(user => user.Email == UserToLogIn.Email && user.Password == UserToLogIn.Password).FirstOrDefault();

            if (user == null)
            {
                _signInView.DisplayAlert("Error", "Email or Password aren't right", "Accept");
                return;
            }

            _signInView.DisplayAlert("Success", "You Logged in", "Accept");
            LoggedUser.SetValues(user);
        }
    }
}