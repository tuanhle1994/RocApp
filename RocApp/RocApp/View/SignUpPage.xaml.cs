using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RocApp.Database;
using RocApp.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RocApp;

namespace RocApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : CarouselPage
    {
        public SignUpPage()
        {
            InitializeComponent();

            Choices();
        }

        List<String> ChoicesList = new List<String>();

        DataManagerClass addUser = new DataManagerClass();

        private void signUpbt_Clicked(object sender, EventArgs e)
        {
            UserProperties add = new UserProperties();
            add.Username = username.Text;
            if (password.Text == confirmPassword.Text)
            {
                add.Password = password.Text;
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Error", "Passwords don't match", "Ok");
            }
            add.Fullname = fullname.Text;
            add.Mood1 = mood1.SelectedItem.ToString();
            add.Mood2 = mood2.SelectedItem.ToString();
            add.Mood3 = mood3.SelectedItem.ToString();
            add.Mood4 = mood4.SelectedItem.ToString();
            add.Mood5 = mood5.SelectedItem.ToString();
            add.Mood6 = mood6.SelectedItem.ToString();
            add.Mood7 = mood7.SelectedItem.ToString();
            add.Mood8 = mood8.SelectedItem.ToString();

            addUser.SaveDataOnDatabase(add.Fullname, add.Username, add.Password, add.Mood1, add.Mood2, add.Mood3, add.Mood4, add.Mood5, add.Mood6, add.Mood7, add.Mood8);

        }
        // The Choices
        public void Choices()
        {
            ChoicesList.Add("Strongly Agree");
            ChoicesList.Add("Moderately Agree");
            ChoicesList.Add("Agree");
            ChoicesList.Add("Disagree");
            ChoicesList.Add("Strongly Disagree");
            ChoicesList.Add("Neutral");

            mood1.ItemsSource = ChoicesList;
            mood2.ItemsSource = ChoicesList;
            mood3.ItemsSource = ChoicesList;
            mood4.ItemsSource = ChoicesList;
            mood5.ItemsSource = ChoicesList;
            mood6.ItemsSource = ChoicesList;
            mood7.ItemsSource = ChoicesList;
            mood8.ItemsSource = ChoicesList;
        }
    }
}