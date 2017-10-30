using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using ReadDataFromJson;
using ReadDataFromJson.iOS;
using Foundation;
using UIKit;

[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePicker_iOS))]
namespace ReadDataFromJson.iOS
{
    public class CustomDatePicker_iOS :DatePickerRenderer
    {
        public CustomDatePicker_iOS()
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);
			if (Control != null)
			{
				// do whatever you want to the UITextField here!
				Control.BackgroundColor = UIColor.Clear;
				Control.BorderStyle = UITextBorderStyle.None;
				Control.Font = UIFont.FromName("Arial", 16);
				Control.TextColor = UIColor.FromRGB(74, 74, 74);
			
			}
        }
    }
}
