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

    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(username.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(password.Text);

            if (isEmailEmpty || isPasswordEmpty)
            {
                DisplayAlert("Error", "Username and password cannot be empty", "Ok");
            }

            else
            {
                DataManagerClass data = new DataManagerClass();
                foreach (var item in data.GetProperties())
                {
                    if (item.Username.Equals(username.Text) && item.Password.Equals(password.Text))
                    {
                        Navigation.PushAsync(new HomePage());
                        break;
                    }
                }
            }
        }

        private void RegisterUSerButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}