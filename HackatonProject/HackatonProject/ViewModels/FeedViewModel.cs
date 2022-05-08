using HackatonProject.Models;
using HackatonProject.Views;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class FeedViewModel
    {
        public List<Publication> Publications { get; set; }
        public List<Organization> Organizations { get; set; }
        public NavigationCommand<CreateConferenceView> ToCreateConferenceCommand { get; set; } = new();
        public NavigationCommand<EnterConferenceView> ToEnterConferenceCommand { get; set; } = new();
        public NavigationCommand<ScheduleConferenceView> ToScheduleConferenceCommand { get; set; } = new();

        public FeedViewModel()
        {
            AppContext appContext = DependencyService.Get<AppContext>();

            Publications = appContext.Publications.ToList();
            Organizations = appContext.Organizations.ToList();
        }
    }
}