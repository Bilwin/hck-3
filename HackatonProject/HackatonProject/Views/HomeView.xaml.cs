using Xamarin.Forms;
using Xamarin.Forms.Vonage;

namespace HackatonProject.Views
{
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();

            CrossVonage.Current.ApiKey = "HZgdp72QANb1oM52"; // Vonage API key from your account
            CrossVonage.Current.SessionId = "737510880"; // Id of session for connecting
            CrossVonage.Current.UserToken = "{YOUR_USER_TOKEN}"; // User's token

            if (!CrossVonage.Current.TryStartSession())
            {
                return;
            }
            bool b = CrossVonage.Current.TrySendMessage("Lexa");
        }
    }
}