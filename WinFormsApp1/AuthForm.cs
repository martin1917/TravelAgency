﻿using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http.Json;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var credentials = new LoginModel
            {
                Login = tbLogin.Text,
                Password = tbPassword.Text
            };

            var results = new List<ValidationResult>();
            var context = new ValidationContext(credentials);
            if (!Validator.TryValidateObject(credentials, context, results, true))
            {
                var errorMessage = string.Join("\n", results.Select(err => $"• {err.ErrorMessage};"));
                MessageBox.Show($"{errorMessage}", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var httpClient = HttpClientFactory.Create();

            var loginResponse = await httpClient.PostAsJsonAsync("auth/login", credentials);
            if (loginResponse.StatusCode != HttpStatusCode.OK && loginResponse.StatusCode == HttpStatusCode.NotFound)
            {
                MessageBox.Show($"Ошибка входа\nНеверно указан логин или пароль", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var authResponse = await loginResponse.Content.ReadFromJsonAsync<AuthResponse>();
            
            CurrentUser.Username = authResponse.Username;
            CurrentUser.Role = authResponse.Role;
            CurrentUser.AccessToken = authResponse.AccessToken;

            var mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => Show();
            mainForm.Show();
            Hide();
        }

        private async void btnRegistrate_Click(object sender, EventArgs e)
        {
            var newClient = new RegistrationModel
            {
                SecondName = tbSecondName.Text,
                Name = tbName.Text,
                Patronymic = tbPatronymic.Text,
                Birthday = dtpBirthday.Value,
                Email = tbEmail.Text,
                PhoneNumber = tbPhoneNumber.Text,
                Login = tbLoginNew.Text,
                Password = tbPasswordNew.Text,
                RepeatPassword = tbRepeatPassword.Text
            };

            var results = new List<ValidationResult>();
            var context = new ValidationContext(newClient);
            if (!Validator.TryValidateObject(newClient, context, results, true))
            {
                var errorMessage = string.Join("\n", results.Select(err => $"• {err.ErrorMessage};"));
                MessageBox.Show($"{errorMessage}", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var httpClient = HttpClientFactory.Create();

            var response = await httpClient.PostAsJsonAsync("auth/registration", newClient);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show($"Создание успешно", "Ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Ошибка\nПользователь с таким логином уже существует", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
