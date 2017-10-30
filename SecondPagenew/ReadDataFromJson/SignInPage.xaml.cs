using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ReadDataFromJson
{
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
			InitializeComponent();
			submitRef.Clicked += (object sender, EventArgs e) =>
			  {
				  Navigation.PushAsync(new SecondPage());
			  };
        }
    }
}
