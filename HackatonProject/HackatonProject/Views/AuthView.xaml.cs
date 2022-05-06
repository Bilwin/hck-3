using Xamarin.Forms;

namespace HackatonProject.Views
{
    public partial class AuthView : ContentPage
    {
        public AuthView()
        {
            DependencyService.RegisterSingleton(Navigation);

            InitializeComponent();
        }
    }
}