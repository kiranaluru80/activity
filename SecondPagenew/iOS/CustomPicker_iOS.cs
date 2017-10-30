using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using ReadDataFromJson;
using ReadDataFromJson.iOS;
using Foundation;
using UIKit;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPicker_iOS))]
namespace ReadDataFromJson.iOS
{
    public class CustomPicker_iOS : PickerRenderer
    {
        public CustomPicker_iOS()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
			if (Control != null)
			{



				// perform initial setup
				// do whatever you want to the UITextField here!
				Control.BackgroundColor = UIColor.Clear;
				Control.BorderStyle = UITextBorderStyle.None;
				Control.Font = UIFont.FromName("Arial", 16);
				Control.TextColor = UIColor.FromRGB(74, 74, 74);
				//Control.Placeholder = "From";
				//Control.Text = "From";
				//Control.Text = Convert.ToString(String.Format ("{0:M/dd/yyyy}", DateTime.Now));
				//Control.TextColor = UIColor.FromRGB (189,189,189);


				//Change Placeholder text color
				//NSAttributedString placeholderString = new NSAttributedString(Control.Placeholder, new UIStringAttributes(){ ForegroundColor = UIColor.White,Font=UIFont.FromName ("Arial", 12) });
				//Control.AttributedPlaceholder = placeholderString;


			}
        }
    }
}
