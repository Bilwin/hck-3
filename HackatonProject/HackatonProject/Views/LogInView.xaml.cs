using HackatonProject.ViewModels;
using Xamarin.Forms;

namespace HackatonProject.Views
{
    public partial class LogInView : ContentPage
    {
        public LogInView()
        {
            InitializeComponent();

            BindingContext = new LogInViewModel(this);
        }
    }
}