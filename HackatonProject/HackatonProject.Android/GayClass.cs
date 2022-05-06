using Android.Content;
using Android.Graphics.Drawables;
using Android.Text;
using HackatonProject;
using HackatonProject.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRendererAndroid))]

namespace HackatonProject.Droid
{
    public class CustomEntryRendererAndroid : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                GradientDrawable gd = new();
                gd.SetColor(Android.Graphics.Color.Transparent);
                Control.SetBackground(gd);
                Control.SetPadding(20, 0, 0, 0);

                CustomEntry customEntry = (CustomEntry)e.NewElement;
                if (customEntry.IsPasswordFlag)
                {
                    Control.InputType = InputTypes.TextVariationVisiblePassword;
                }

            }
        }

        public CustomEntryRendererAndroid(Context context)
            : base(context)
        {
        }
    }
}