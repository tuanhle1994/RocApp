using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RocApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage ()
		{
			InitializeComponent ();
		}

    private void RegisterButton_Clicked(object sender, EventArgs e)
    {
      if (passwordEntry.Text == confirmPasswordEntry.Text)
      {
        // passwords match
      }
      else
      {
        DisplayAlert("Error", "Passwords don't match", "Ok");
      }
    }
  }
}