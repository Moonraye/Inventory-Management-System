using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Windows.Forms;
using Inventory_Manager.Services;

namespace Inventory_Manager
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        private readonly InventoryService _manager;
        private readonly SupabaseService _dbService;

        public LoginForm(InventoryService manager, SupabaseService dbService)
        {
            InitializeComponent();
            _manager = manager;
            _dbService = dbService;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                await _dbService.InitializeAsync(); // Ініціалізуємо підключення до Supabase при завантаженні форми
            }
            catch (Exception ex) // Якщо виникає помилка при підключенні до сервера, виводимо повідомлення і блокуємо кнопку логіну
            {
                MessageBox.Show($"Server connecting error: {ex.Message}");
                btnLogin.Enabled = false;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e) // Обробник кліку по кнопці логіну
        {
            string email = txtEmail.Text.Trim(); // Зчитуємо email і пароль з текстових полів, видаляючи зайві пробіли
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) // Якщо будь-яке з полів порожнє, виводимо повідомлення і не намагаємося логінитися
            {
                MessageBox.Show("Email and password are required.");
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Loading...";

            bool isSuccess = await _manager.LoginUserAsync(email, password); // Викликаємо метод логіну

            if (isSuccess)
            {
                this.DialogResult = DialogResult.OK; // кажемо системі, що вікно закрилося успішно, якщо все працює

                this.Close(); // Вікно закривається, після чого Program.cs відкриє головну форму
            }
            else
            {
                MessageBox.Show("Email or password are invalid!", "Authentification error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Повертаємо кнопку в нормальний стан
                btnLogin.Enabled = true;
                btnLogin.Text = "LOGIN";
                txtPassword.Clear(); // Очищаємо пароль для нової спроби
            }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email and password are required.");
                return;
            }

            // Блокуємо обидві кнопки під час запиту
            btnRegister.Enabled = false;
            btnLogin.Enabled = false;
            btnRegister.Text = "Loading...";

            bool isRegistered = await _manager.RegisterUserAsync(email, password); // намагаємося зареєструвати


            if (isRegistered)
            {
                bool isLoggedIn = await _manager.LoginUserAsync(email, password); // Якщо реєстрація успішна - одразу викликаємо логін


                if (isLoggedIn)
                {
                    // Закриваємо форму логіну з успішним результатом, Program.cs запустить головне вікно
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // На випадок якоїсь магії, якщо логін після реєстрації не спрацював
                    MessageBox.Show("Automatic login error. Try logging in manually.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnRegister.Enabled = true;
                    btnLogin.Enabled = true;
                    btnRegister.Text = "REGISTER";
                }
            }
            else
            {
                MessageBox.Show("Register error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Повертаємо кнопки в нормальний стан
                btnRegister.Enabled = true;
                btnLogin.Enabled = true;
                btnRegister.Text = "REGISTER";
            }
        }
    }
}
