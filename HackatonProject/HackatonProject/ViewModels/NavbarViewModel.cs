using HackatonProject.Models;
using HackatonProject.Views;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class NavbarViewModel
    {
        public User User { get; set; }
        public NavigationCommand<ProfileView> ToProfileCommand { get; set; } = new();
        public NavigationCommand<FeedView> ToFeedCommand { get; set; } = new();

        public NavbarViewModel()
        {
            User = DependencyService.Get<User>();
        }
    }
}