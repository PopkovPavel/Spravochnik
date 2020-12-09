using Spravochnik.Data;
using Spravochnik.Data.User;
using System;
using Xamarin.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace Spravochnik
{
    public partial class RegPage : ContentPage
    {
        public RegPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void regAcceptButton_Clicked(object sender, EventArgs e)
        {
            if (_mail.Text == "")
            {
                DisplayAlert("Ошибка", "Введите почту", "OK");
            }
            else if (_pass1.Text == "" || _pass2.Text == "")
            {
                DisplayAlert("Ошибка", "Введите пароль", "OK");
            }
            else if (_pass1.Text != _pass2.Text)
            {
                DisplayAlert("Ошибка", "Пароли не совпадают", "OK");
            }
            else
            {
                try
                {
                    var client = new RestClient("https://api-eldoed.herokuapp.com/signup");
                    client.Timeout = -1;
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                    request.AddParameter("email", _mail.Text.ToString());
                    request.AddParameter("password", _pass1.Text.ToString());
                    IRestResponse response = client.Execute(request);

                    string responseData = response.Content.ToString();

                    JSONauth tempUser = JsonConvert.DeserializeObject<JSONauth>(responseData);

                    UserInfo.Email = tempUser.Data.Email;
                    UserInfo.Message = tempUser.Message;
                    UserInfo.Role = tempUser.Data.Role;
                    UserInfo.Token = tempUser.Token;

                    DisplayAlert("Выполнено", "Регистрация прошла успешно", "OK");
                    var page = new AppShell(UserInfo.Email);
                    (Application.Current.MainPage) = page;
                }
                catch
                {
                    DisplayAlert("Что-то пошло не так", "Возможно пользователь с таким E-Mail-ом уже существует", "ОК");
                }
            }
        }
    }
}