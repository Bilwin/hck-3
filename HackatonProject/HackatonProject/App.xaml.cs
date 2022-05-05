using HackatonProject.Views;
using Xamarin.Forms;

namespace HackatonProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HomeView();
        }
    }
}