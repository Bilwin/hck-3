using Xamarin.Forms;

namespace HackatonProject
{
    public class CustomEntry : Entry
    {
        public static readonly BindableProperty IsPasswordFlagProperty =
            BindableProperty.Create("IsPasswordFlag", typeof(bool), typeof(CustomEntry), defaultBindingMode: BindingMode.OneWay);

        public bool IsPasswordFlag
        {
            get => (bool)GetValue(IsPasswordFlagProperty);
            set => SetValue(IsPasswordFlagProperty, value);
        }
    }
}