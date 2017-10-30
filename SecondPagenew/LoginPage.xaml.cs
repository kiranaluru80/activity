using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ReadDataFromJson
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
			NavigationPage.SetHasBackButton(this, false);

			InitializeComponent();
			submitRef.Clicked += (object sender, EventArgs e) =>
              {
                Navigation.PushAsync(new SecondPage());
              };
        }
    }
}
