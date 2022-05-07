using HackatonProject.Models;
using HackatonProject.Views;
using System;
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

            MainPage = new NavigationPage(new AuthView());
        }

        private static void InitializeDatabase()
        {
            string dbPath = DependencyService.Get<IPath>().GetDatabasePath(DB_NAME);

            AppContext db = new(dbPath);

            //db.Users.Add(new User(1, "xxyy", "79142916675", "meow20042006@gmail.com", "top_sec"));

            //var org1 = new Organization(1, "teamLogo.png", "Анонс нашей крупнейшей игры", "windows.fans", 5);
            //var org2 = new Organization(2, "teamLogo.png", "открытие нового сервера", "newawe", 0);

            //db.Organizations.Add(org1);
            //db.Organizations.Add(org2);

            //var post1 = new Publication(1, 1, "Всем привет. Сегодня мы допилим наш прототип и совсем скоро выйдем в релиз!", DateTime.Now, 3);
            //var post2 = new Publication(2, 2, "Всем привет. Сегодня видеовстреча в 14:00", DateTime.Now, 0);

            //db.Publications.Add(post1);
            //db.Publications.Add(post2);

            //db.SaveChanges();

            DependencyService.RegisterSingleton(db);
            DependencyService.RegisterSingleton(new User());
        }
    }
}