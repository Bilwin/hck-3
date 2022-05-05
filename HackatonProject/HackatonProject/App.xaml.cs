using HackatonProject.Models;
using HackatonProject.Views;
using Xamarin.Forms;

namespace HackatonProject
{
    public partial class App : Application
    {
        private const string DB_NAME = "users.db";

        public App()
        {
            InitializeComponent();
            InitializeDatabase();

            MainPage = new NavigationPage(new WelcomeView());
        }

        private static void InitializeDatabase()
        {
            string dbPath = DependencyService.Get<IPath>().GetDatabasePath(DB_NAME);

            DependencyService.RegisterSingleton(new AppContext(dbPath));
            DependencyService.RegisterSingleton(new User());
        }
    }
}