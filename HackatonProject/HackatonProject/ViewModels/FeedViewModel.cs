using HackatonProject.Models;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace HackatonProject.ViewModels
{
    public class FeedViewModel
    {
        public List<Publication> Publications { get; set; }
        public List<Organization> Organizations { get; set; }

        public FeedViewModel()
        {
            var appContext = DependencyService.Get<AppContext>();

            Publications = appContext.Publications.ToList();
            Organizations = appContext.Organizations.ToList();
        }
    }
}