using HackatonProject.ViewModels;
using Xamarin.Forms;

namespace HackatonProject.Views
{
    public partial class WelcomeView : ContentPage
    {
        public WelcomeView()
        {
            DependencyService.RegisterSingleton(Navigation);

            InitializeComponent();
        }
    }
}