using HackatonProject.Models;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class ProfileViewModel
    {
        public User User { get; set; }

        public ProfileViewModel()
        {
            User = DependencyService.Get<User>();
        }
    }
}