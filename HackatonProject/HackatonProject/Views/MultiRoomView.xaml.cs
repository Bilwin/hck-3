using HackatonProject.ViewModels;
using Xamarin.Forms;

namespace HackatonProject.Views
{
    public partial class MultiRoomView : ContentPage
    {
        public MultiRoomView(string roomTitle)
        {
            InitializeComponent();  

            MultiRoomViewModel multiRoomViewModel = new(roomTitle);
            BindingContext = multiRoomViewModel;
            multiRoomViewModel.Init();
        }
    }
}