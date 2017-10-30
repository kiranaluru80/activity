using System;
using CoreGraphics;
using ReadDataFromJson.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(ShadowNavigationBarRenderer))]
namespace ReadDataFromJson.iOS
{
    public class ShadowNavigationBarRenderer : NavigationRenderer
    {
        public ShadowNavigationBarRenderer()
        {
        }
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
			if (this.Element == null) return;

            NavigationBar.Layer.ShadowColor = UIColor.Gray.CGColor;
			NavigationBar.Layer.ShadowOffset = new CGSize(2, 2);
			NavigationBar.Layer.ShadowOpacity = 2;

			
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			//this.NavigationBar.TitleTextAttributes = new UIStringAttributes()
			//{
			//	Font = UIFont.FromName("HelveticaNeue-Light", 20),



			//};
        }
    }
}
