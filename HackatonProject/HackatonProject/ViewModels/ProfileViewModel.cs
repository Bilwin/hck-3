using HackatonProject.Models;
using HackatonProject.Views;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class ProfileViewModel
    {
        public User User { get; set; }
        public NavigationCommand<FeedView> ToFeedCommand { get; set; } = new();


        public ProfileViewModel()
        {
            User = DependencyService.Get<User>();
        }
    }
}