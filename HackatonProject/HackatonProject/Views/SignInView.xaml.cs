using HackatonProject.ViewModels;
using Xamarin.Forms;

namespace HackatonProject.Views
{
    public partial class SignInView : ContentPage
    {
        public SignInView()
        {
            InitializeComponent();

            BindingContext = new SignInViewModel(this);
        }
    }
}