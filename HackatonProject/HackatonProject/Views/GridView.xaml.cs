using Xamarin.Forms;

namespace HackatonProject.Views
{
    public partial class GridView : ContentView
    {
        public GridView()
        {
            InitializeComponent();
        }

        public View Body
        {
            get => BodyContent.Content;
            set => BodyContent.Content = value;
        }
    }
}